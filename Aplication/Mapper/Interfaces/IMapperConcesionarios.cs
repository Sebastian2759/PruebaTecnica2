using Dominio.Entidades.VentasVehiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Mapper.Interfaces
{
    public interface IMapperConcesionarios
    {
        List<ConcesionariosGlobalDto> EntidadToDto(List<ConcesionariosGlobalEntidad> entidad);
    }
}
