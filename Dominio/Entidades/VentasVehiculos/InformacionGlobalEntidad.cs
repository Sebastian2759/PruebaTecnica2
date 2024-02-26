﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.VentasVehiculos
{
    public class InformacionGlobalEntidad
    {
        [Key]

        public int InformacionGlobalID { get; set; }
        public int TransaccionID { get; set; }
        public int VehiculoID { get; set; }
        public int ClienteID { get; set; }
        public int ConcesionarioID { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal PrecioVenta { get; set; }
    }
}
