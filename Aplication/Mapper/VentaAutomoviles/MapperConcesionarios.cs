using Aplication.Mapper.Interfaces;
using AutoMapper;
using Dominio.Entidades.VentasVehiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Mapper.VentaAutomoviles
{
    public class MapperConcesionarios : IMapperConcesionarios
    {
        private readonly IMapper _mapper;
        public MapperConcesionarios(IMapper mapper)
        {
            _mapper = mapper;
        }
        public List<ConcesionariosGlobalDto> EntidadToDto(List<ConcesionariosGlobalEntidad> entidad)
        {
            return _mapper.Map<List<ConcesionariosGlobalDto>>(entidad);
        }
    }
}
