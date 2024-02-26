using Dominio.Entidades.VentasVehiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Servicios.VentaAutomoviles.Interfaces
{
    public interface IServicioClientes
    {
        Task<List<ClientesGlobalDto>> GetClientes();
    }
}
