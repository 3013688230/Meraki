using System;
using System.Collections.Generic;

#nullable disable

namespace Meraki.Entities
{
    public partial class Barrio
    {
        public Barrio()
        {
            Clientes = new HashSet<Cliente>();
            Conductores = new HashSet<Conductore>();
            Propietarios = new HashSet<Propietario>();
            Servicios = new HashSet<Servicio>();
        }

        public int IdBarrio { get; set; }
        public int IdMunicipio { get; set; }
        public string NombreBarrio { get; set; }

        public virtual Municipio IdMunicipioNavigation { get; set; }
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Conductore> Conductores { get; set; }
        public virtual ICollection<Propietario> Propietarios { get; set; }
        public virtual ICollection<Servicio> Servicios { get; set; }
    }
}
