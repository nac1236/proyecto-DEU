using System;
using System.Collections.Generic;

namespace ProyectoDEU_API
{
    public partial class Docente
    {
        public Docente()
        {
            Cursos = new HashSet<Curso>();
            IdQuizzes = new HashSet<Quiz>();
        }

        public Guid Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<Curso> Cursos { get; set; }

        public virtual ICollection<Quiz> IdQuizzes { get; set; }
    }
}
