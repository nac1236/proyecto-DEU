using System.ComponentModel.DataAnnotations;

namespace ProyectoDEU_API.Models.Authentication
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        public bool EsDocente { get; set; }

        //estos 3 atributos capaz podemos borrarlos
        //public Guid? UserId { get; set; }

        //public LoginStatus Status { get; set; }

        //public List<string> Errors { get; set; }
    }
}
