using System;
using System.Collections.Generic;

#nullable disable

namespace Meraki.Entities
{
    public partial class Departamento
    {
        public Departamento()
        {
            Municipios = new HashSet<Municipio>();
        }

        public int IdDepartamento { get; set; }
        public string NombreDepartamento { get; set; }

        public virtual ICollection<Municipio> Municipios { get; set; }
    }
}
