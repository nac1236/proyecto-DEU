using System;
using System.Collections.Generic;

namespace ProyectoDEU_API
{
    public partial class Respuestum
    {
        public Guid Id { get; set; }
        public string Texto { get; set; } = null!;
        public byte EsCorrecta { get; set; }
        public Guid IdPregunta { get; set; }

        public virtual Pregunta IdPreguntaNavigation { get; set; } = null!;
    }
}
