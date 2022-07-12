using System;
using System.Collections.Generic;

namespace ProyectoDEU_API
{
    public partial class Quiz
    {
        public Quiz()
        {
            Pregunta = new HashSet<Pregunta>();
            IdDocentes = new HashSet<Docente>();
        }

        public Guid Id { get; set; }
        public string Titulo { get; set; } = null!;
        public Guid IdCurso { get; set; }

        public virtual Curso IdCursoNavigation { get; set; } = null!;
        public virtual ICollection<Pregunta> Pregunta { get; set; }

        public virtual ICollection<Docente> IdDocentes { get; set; }
    }
}
