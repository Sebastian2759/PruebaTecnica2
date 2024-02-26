using Aplication.Dto;
using Aplication.Mapper.Configuration;
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
    public class MapperTransaccionesGlobal : IMapperTransaccionesGlobal
    {
        private readonly IMapper _mapper;
        public MapperTransaccionesGlobal(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<TransaccionesGlobalDto> MapListTransaccionesGlobalDto(List<TransaccionesGlobalEntidad> transaccionesGlobalEntidad)
        {
            return _mapper.Map<List<TransaccionesGlobalDto>>(transaccionesGlobalEntidad);
        }
        public TransaccionesGlobalDto MapTransaccionesGlobalDto(TransaccionesGlobalEntidad transaccionesGlobalEntidad)
        {
            return _mapper.Map<TransaccionesGlobalDto>(transaccionesGlobalEntidad);
        }
        public TransaccionesGlobalEntidad MapTransaccionesGlobalEntidad(TransaccionesGlobalDto dto)
        {
            return _mapper.Map<TransaccionesGlobalEntidad>(dto);
        }
    }
}
