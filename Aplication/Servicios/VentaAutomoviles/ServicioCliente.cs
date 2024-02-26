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
    public class ServicioCliente : IServicioClientes
    {
        private readonly IRepositorioClienteGlobal _repositorioClienteGlobal;
        private readonly IMapperClientes _mapper;
        
        public ServicioCliente(IRepositorioClienteGlobal repositorioClienteGlobal, IMapperClientes mapper)
        {
            _repositorioClienteGlobal = repositorioClienteGlobal;
            this._mapper = mapper;
        }

        public async Task<List<ClientesGlobalDto>> GetClientes()
        {
            return _mapper.entidadToDto(await _repositorioClienteGlobal.GetClientes());
        }
    }
}
