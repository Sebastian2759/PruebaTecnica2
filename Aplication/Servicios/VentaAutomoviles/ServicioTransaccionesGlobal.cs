using Aplication.Dto;
using Aplication.Mapper.Interfaces;
using Aplication.Servicios.VentaAutomoviles.Interfaces;
using Dominio.Interfaces;
using Infraestructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Servicios.VentaAutomoviles
{
    public class ServicioTransaccionesGlobal : IServicioTransaccionesGlobal
    {
        private readonly IRepositorioTransaccionesGlobal _repositorioTransaccionesGlobal;
        private readonly IMapperTransaccionesGlobal _mapper;
        public ServicioTransaccionesGlobal(IRepositorioTransaccionesGlobal repositorioTransaccionesGlobal, IMapperTransaccionesGlobal mapper)
        {
            _repositorioTransaccionesGlobal = repositorioTransaccionesGlobal;
            _mapper = mapper;
        }

        public async Task<TransaccionesGlobalDto> ActualizarTransaccionesGlobal(TransaccionesGlobalDto dto)
        {
            return _mapper.MapTransaccionesGlobalDto(await _repositorioTransaccionesGlobal.ActualizarTransaccionesGlobal(_mapper.MapTransaccionesGlobalEntidad(dto)));
        }

        public async Task<bool> CrearTransaccionGlobal(TransaccionesGlobalDto dto)
        {
            try
            {
                return await _repositorioTransaccionesGlobal.CrearTransaccionGlobal(_mapper.MapTransaccionesGlobalEntidad(dto));
            }
            catch (Exception e)
            {

                throw e.InnerException;
            }


        }

        public async Task<string> EliminarTransaccionesGlobal(int transaccionID)
        {
            return await _repositorioTransaccionesGlobal.EliminarTransaccionesGlobal(transaccionID);
        }

        public async Task<TransaccionesGlobalDto> GetTransaccionesGlobal(int transaccionID)
        {
            return _mapper.MapTransaccionesGlobalDto(await _repositorioTransaccionesGlobal.GetTransaccionesGlobal(transaccionID));
        }

        public async Task<List<TransaccionesGlobalDto>> GetTransaccionesGlobales()
        {
            return _mapper.MapListTransaccionesGlobalDto( _repositorioTransaccionesGlobal.GetTransaccionesGlobales());
        }
    }
}
