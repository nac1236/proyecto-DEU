using System;
using System.Collections.Generic;

namespace ProyectoDEU_API
{
    public partial class Pregunta
    {
        public Pregunta()
        {
            Respuesta = new HashSet<Respuestum>();
        }

        public Guid Id { get; set; }
        public string Texto { get; set; } = null!;
        public Guid IdQuiz { get; set; }
        public Guid? IdRecurso { get; set; }

        public virtual Quiz IdQuizNavigation { get; set; } = null!;
        public virtual Recurso? IdRecursoNavigation { get; set; }
        public virtual ICollection<Respuestum> Respuesta { get; set; }
    }
}
