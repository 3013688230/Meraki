﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Meraki.Entities
{
    public partial class Vehiculo
    {
        public Vehiculo()
        {
            Conductores = new HashSet<Conductore>();
        }

        public string CodigoV { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int Cilindraje { get; set; }
        public string Soat { get; set; }
        public string TecnoMecanica { get; set; }
        public string Placa { get; set; }
        public string FotoV { get; set; }
        public string SeguroCarga { get; set; }
        public int IdPropietario { get; set; }
        public int IdTipoVehiculo { get; set; }

        public virtual Propietario IdPropietarioNavigation { get; set; }
        public virtual TipoVehiculo IdTipoVehiculoNavigation { get; set; }
        public virtual ICollection<Conductore> Conductores { get; set; }
    }
}
