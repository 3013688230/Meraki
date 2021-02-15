using System;
using System.Collections.Generic;

#nullable disable

namespace Meraki.Entities
{
    public partial class Municipio
    {
        public Municipio()
        {
            Barrios = new HashSet<Barrio>();
        }

        public int IdMunicipio { get; set; }
        public int IdDepartamento { get; set; }
        public string NombreMunicipio { get; set; }

        public virtual Departamento IdDepartamentoNavigation { get; set; }
        public virtual ICollection<Barrio> Barrios { get; set; }
    }
}
