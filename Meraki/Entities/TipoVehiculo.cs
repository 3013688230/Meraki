using System;
using System.Collections.Generic;

#nullable disable

namespace Meraki.Entities
{
    public partial class TipoVehiculo
    {
        public TipoVehiculo()
        {
            Servicios = new HashSet<Servicio>();
            Vehiculos = new HashSet<Vehiculo>();
        }

        public int IdTipoVehiculo { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Servicio> Servicios { get; set; }
        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
