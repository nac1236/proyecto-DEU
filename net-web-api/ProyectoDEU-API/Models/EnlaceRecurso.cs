using System;
using System.Collections.Generic;

namespace ProyectoDEU_API
{
    public partial class EnlaceRecurso
    {
        public Guid Id { get; set; }
        public Guid IdRecurso { get; set; }
        public string Enlace { get; set; } = null!;

        public virtual Recurso IdRecursoNavigation { get; set; } = null!;
    }
}
