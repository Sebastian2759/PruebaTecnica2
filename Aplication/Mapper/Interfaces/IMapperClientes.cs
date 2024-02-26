using Dominio.Entidades.VentasVehiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Mapper.Interfaces
{
    public interface IMapperClientes
    {
        List<ClientesGlobalDto> entidadToDto(List<ClientesGlobalEntidad> entidad);    
    }
}
