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
    public class ServicioAutomoviles : IServicioAutomoviles
    {
        private readonly IRepositorioVehiculoGlobal _repositorioVehiculoGlobal;
        private readonly IMapperVehiculo _mapperVehiculo;

        public ServicioAutomoviles(IRepositorioVehiculoGlobal repositorioVehiculo, IMapperVehiculo mapperVehiculo )
        {
            _repositorioVehiculoGlobal = repositorioVehiculo;
            _mapperVehiculo = mapperVehiculo;
        }
        public async Task<List<VehiculosGlobalDto>> GetVehiculos()
        {
            return _mapperVehiculo.EntidadToDto(await _repositorioVehiculoGlobal.GetVehiculos());
        }
    }
}
