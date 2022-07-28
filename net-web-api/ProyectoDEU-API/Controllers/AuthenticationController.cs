using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ProyectoDEU_API.Models.Authentication;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace ProyectoDEU_API.Controllers
{
    public class AuthenticationController : Controller
    {
        public static readonly TimeSpan DefaultTokenDuration = TimeSpan.FromHours(3);

        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<AppRole> roleManager;
        private readonly IConfiguration _configuration;

        public AuthenticationController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this._configuration = configuration;
        }

        [HttpPost]
        [Route("api/login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var response = new LoginResponse
            {
                Username = model?.Username,
                IsValid = false
            };

            try
            {
                var user = await userManager.FindByNameAsync(model.Username);
                if (user == null)
                {
                    response.Status = LoginStatus.InvalidUserName;
                    return Ok(response);
                }

                //if (user.LockoutEnabled && await userManager.IsLockedOutAsync(user))
                //{
                //    response.Status = LoginStatus.UserLocked;
                //    return Ok(response);
                //}

                var loginIsValid = await userManager.CheckPasswordAsync(user, model.Password);
                if (loginIsValid)
                {
                    var authClaims = new List<Claim> {
                        new Claim(ClaimTypes.Name, user.UserName),
                        new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                        new Claim(ClaimTypes.Email, user.Email),
                    };

                    var userRoles = await userManager.GetRolesAsync(user);
                    foreach (var userRole in userRoles)
                    {
                        authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                    }

                    var token = GenerateJwtToken(authClaims);

                    //var session = await CreateSessionAsync(user, token);

                    //response.Email = user.Email;
                    response.Status = LoginStatus.Success;
                    response.IsValid = loginIsValid;
                    response.AuthToken = new JwtSecurityTokenHandler().WriteToken(token);
                    //response.SessionId = session?.Id;
                    //response.UserId = user.Id; va en el token

                    //user.LastLoginDate = DateTimeOffset.Now;
                    await userManager.UpdateAsync(user);

                }
                else
                {
                    response.Status = LoginStatus.InvalidPassword;
                }
            }
            catch (Exception ex)
            {
                response.Status = LoginStatus.ServerError;
                response.StatusText = ex.Message;
            }

            return Ok(response);
        }

        // TODO: ver como registrar roles docente/estudiante
        // docentes solo registrados por el admin?
        [HttpPost]
        [Route("api/register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            var userExists = await userManager.FindByNameAsync(model.Username);
            if (userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User already exists!" });

            AppUser user = new()
            {
                Id = Guid.NewGuid(),
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Username
            };
            var result = await userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response
                {
                    Status = "Error",
                    Message = "User creation failed! Please check user details and try again.",
                    Errors = result.Errors.Select(e => e.Description).ToList()
                });

            return Ok(new Response { Status = "Success", Message = "User created successfully!" });
        }

        [HttpPost]
        [Route("api/register-admin")]
        public async Task<IActionResult> RegisterAdmin([FromBody] RegisterModel model)
        {
            var userExists = await userManager.FindByNameAsync(model.Username);
            if (userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User already exists!" });

            AppUser user = new AppUser()
            {
                Id = Guid.NewGuid(),
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Username,
                //CreationDate = DateTimeOffset.Now,
                //IsApproved = true
            };
            var result = await userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response
                {
                    Status = "Error",
                    Message = "User creation failed! Please check user details and try again.",
                    Errors = result.Errors.Select(e => e.Description).ToList()
                });

            if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                await roleManager.CreateAsync(new AppRole(UserRoles.Admin));

            if (!await roleManager.RoleExistsAsync(UserRoles.Docente))
                await roleManager.CreateAsync(new AppRole(UserRoles.Docente));

            if (!await roleManager.RoleExistsAsync(UserRoles.Estudiante))
                await roleManager.CreateAsync(new AppRole(UserRoles.Estudiante));

            if (await roleManager.RoleExistsAsync(UserRoles.Admin))
            {
                await userManager.AddToRoleAsync(user, UserRoles.Admin);
            }

            return Ok(new Response { Status = "Success", Message = "User created successfully!" });
        }

        private Task CreateSessionAsync(AppUser user, object token)
        {
            throw new NotImplementedException();
        }

        private JwtSecurityToken GenerateJwtToken(List<Claim> authClaims)
        {
            //throw new NotImplementedException();
            authClaims.Insert(0, new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));

            // a chekiar
            var authSigningKey = new SymmetricSecurityKey(_configuration.GetSection("JWT").GetValue<byte[]>("Secret"));

            var tokenValidTo = DateTime.Now.Add(DefaultTokenDuration);

            TimeSpan tokenDuration;
            TimeSpan.TryParse(_configuration["JWT:TokenDuration"], out tokenDuration);
            if (tokenDuration > TimeSpan.Zero)
                tokenValidTo = DateTime.Now.Add(tokenDuration);

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: tokenValidTo,
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

            return token;
        }
    }
}
