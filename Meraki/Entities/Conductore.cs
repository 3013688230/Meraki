using System;
using System.Collections.Generic;

#nullable disable

namespace Meraki.Entities
{
    public partial class Conductore
    {
        public Conductore()
        {
            Servicios = new HashSet<Servicio>();
        }

        public int IdConductor { get; set; }
        public int IdBarrio { get; set; }
        public int IdGenero { get; set; }
        public int IdTipoDocumento { get; set; }
        public string Correo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Celular { get; set; }
        public int NumeroDocumento { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string FotoConductor { get; set; }
        public string CodigoV { get; set; }

        public virtual Vehiculo CodigoVNavigation { get; set; }
        public virtual Barrio IdBarrioNavigation { get; set; }
        public virtual Genero IdGeneroNavigation { get; set; }
        public virtual TiposDocumento IdTipoDocumentoNavigation { get; set; }
        public virtual ICollection<Servicio> Servicios { get; set; }
    }
}
