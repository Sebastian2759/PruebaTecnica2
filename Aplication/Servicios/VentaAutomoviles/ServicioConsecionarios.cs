using Aplication.Mapper.Interfaces;
using Aplication.Servicios.VentaAutomoviles.Interfaces;
using Dominio.Entidades.VentasVehiculos;
using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Servicios.VentaAutomoviles
{
    public class ServicioConsecionarios : IServicioConsecionario
    {
        private readonly IRepositorioConseccionarioGlobal _repositorioConseccionarioGlobal;
        private readonly IMapperConcesionarios _mapperConcesionarios;

        public ServicioConsecionarios(IRepositorioConseccionarioGlobal repositorioConseccionarioGlobal, IMapperConcesionarios mapperConcesionarios)
        {
            _repositorioConseccionarioGlobal = repositorioConseccionarioGlobal;
            _mapperConcesionarios = mapperConcesionarios;
        }

        public async Task<List<ConcesionariosGlobalDto>> GetConcesionarios()
        {
            return _mapperConcesionarios.EntidadToDto(await _repositorioConseccionarioGlobal.GetConcesionarios());
        }
    }
}
