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
    public class MapperClientes : IMapperClientes
    {
        private readonly IMapper mapper;
        public MapperClientes(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public List<ClientesGlobalDto> entidadToDto(List<ClientesGlobalEntidad> entidad)
        {
            return mapper.Map<List<ClientesGlobalDto>>(entidad);
        }
    }
}
