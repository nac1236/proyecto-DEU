using System;
using System.Collections.Generic;

namespace ProyectoDEU_API
{
    public partial class Recurso
    {
        public Recurso()
        {
            EnlaceRecursos = new HashSet<EnlaceRecurso>();
            Pregunta = new HashSet<Preguntum>();
        }

        public Guid Id { get; set; }
        public string Titulo { get; set; } = null!;
        public string Texto { get; set; } = null!;

        public virtual ICollection<EnlaceRecurso> EnlaceRecursos { get; set; }
        public virtual ICollection<Preguntum> Pregunta { get; set; }
    }
}
