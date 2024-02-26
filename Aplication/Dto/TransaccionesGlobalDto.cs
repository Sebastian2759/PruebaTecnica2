using Dominio.Entidades.VentasVehiculos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Dto
{
        public class TransaccionesGlobalDto
        {
            public int transaccionID { get; set; }
            public VehiculosGlobalDto vehiculo { get; set; }
            public int vehiculoID { get; set; }
            public ClientesGlobalDto cliente { get; set; }
            public int clienteID { get; set; }
            public ConcesionariosGlobalDto concesionario { get; set; }
            public int concesionarioID { get; set; }
            public DateTime fechaVenta { get; set; }
            public decimal precioVenta { get; set; }

        
    }
}
