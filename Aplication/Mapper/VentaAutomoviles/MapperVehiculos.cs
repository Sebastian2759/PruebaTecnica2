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
    public class MapperVehiculos : IMapperVehiculo
    {
        private readonly IMapper _mapper;
        public MapperVehiculos(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<VehiculosGlobalEntidad> DtoToEntidad(List<VehiculosGlobalDto> vehiculo)
        {
            return _mapper.Map<List<VehiculosGlobalEntidad>>(vehiculo);
        }

        public List<VehiculosGlobalDto> EntidadToDto(List<VehiculosGlobalEntidad> vehiculos)
        {
            return _mapper.Map<List<VehiculosGlobalDto>>(vehiculos);
        }
    }
}
