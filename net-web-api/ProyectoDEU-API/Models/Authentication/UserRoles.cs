namespace ProyectoDEU_API.Models.Authentication
{
    public class UserRoles
    {
        public const string Admin = "Admin";
        public const string Docente = "Docente";
        public const string Estudiante = "Estudiante";

        public static string[] CanonicalRoles { get; } = new[] {
            Admin, Docente, Estudiante
        };

    }
}
