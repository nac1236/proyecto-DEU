using System;
using System.Collections.Generic;

namespace ProyectoDEU_API
{
    public partial class Curso
    {
        public Curso()
        {
            Quizzes = new HashSet<Quiz>();
            IdEstudiantes = new HashSet<Estudiante>();
        }

        public Guid Id { get; set; }
        public string Nombre { get; set; } = null!;
        public Guid? IdDocente { get; set; }

        public virtual Docente? IdDocenteNavigation { get; set; }
        public virtual ICollection<Quiz> Quizzes { get; set; }

        public virtual ICollection<Estudiante> IdEstudiantes { get; set; }
    }
}
