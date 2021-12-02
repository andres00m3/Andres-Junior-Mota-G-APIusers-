using System;
using System.Collections.Generic;

#nullable disable

namespace APIuser1.Entities
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Genero { get; set; }
        public string Cedula { get; set; }
        public DateTime? FechaDeNacimiento { get; set; }
        public string Cargo { get; set; }
        public string SupervisorInmediato { get; set; }
        public int? DepartamentosId { get; set; }
    }
}
