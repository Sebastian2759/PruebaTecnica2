using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.VentasVehiculos
{
    public class TransaccionesGlobalEntidad
    {
        [Key]

        public int TransaccionID { get; set; }

        [ForeignKey("Vehiculo")]
        public int VehiculoID { get; set; }
        public VehiculosGlobalEntidad Vehiculo { get; set; }

        [ForeignKey("Cliente")]
        public int ClienteID { get; set; }
        public ClientesGlobalEntidad  Cliente { get; set; }

        [ForeignKey("Concesionario")]
        public int ConcesionarioID { get; set; }
        public ConcesionariosGlobalEntidad Concesionario { get; set; }

        public DateTime FechaVenta { get; set; }
        public decimal PrecioVenta { get; set; }
    }
}
