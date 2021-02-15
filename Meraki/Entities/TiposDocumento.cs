using System;
using System.Collections.Generic;

#nullable disable

namespace Meraki.Entities
{
    public partial class TiposDocumento
    {
        public TiposDocumento()
        {
            Clientes = new HashSet<Cliente>();
            Conductores = new HashSet<Conductore>();
            Propietarios = new HashSet<Propietario>();
        }

        public int IdTipoDocumento { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Conductore> Conductores { get; set; }
        public virtual ICollection<Propietario> Propietarios { get; set; }
    }
}
