using System;
using System.Collections.Generic;

#nullable disable

namespace Meraki.Entities
{
    public partial class Propietario
    {
        public Propietario()
        {
            Vehiculos = new HashSet<Vehiculo>();
        }

        public int IdPropietario { get; set; }
        public int IdTipoDocumento { get; set; }
        public int IdGenero { get; set; }
        public int IdBarrio { get; set; }
        public string Correo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int NumeroDocumento { get; set; }
        public int Celular { get; set; }

        public virtual Barrio IdBarrioNavigation { get; set; }
        public virtual Genero IdGeneroNavigation { get; set; }
        public virtual TiposDocumento IdTipoDocumentoNavigation { get; set; }
        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
