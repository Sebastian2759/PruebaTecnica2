using Aplication.Dto;
using Aplication.Servicios.VentaAutomoviles;
using Aplication.Servicios.VentaAutomoviles.Interfaces;
using Dominio.Entidades.VentasVehiculos;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Infraestructure.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransaccionesGlobalController : ControllerBase
    {
        private readonly IServicioTransaccionesGlobal _servicioTransaccionesGlobal;
        private readonly IServicioAutomoviles _servicioAutomoviles;
        private readonly IServicioConsecionario _servicioConcesionarios;
        private readonly IServicioClientes _servicioCliente;
        public TransaccionesGlobalController
            (
            IServicioTransaccionesGlobal servicioTransaccionesGlobal,
            IServicioAutomoviles servicioAutomoviles,
            IServicioConsecionario servicioConsecionario,
            IServicioClientes servicioClientes)
        {
            _servicioTransaccionesGlobal = servicioTransaccionesGlobal;
            _servicioAutomoviles = servicioAutomoviles;
            _servicioConcesionarios = servicioConsecionario;
            _servicioCliente = servicioClientes;
        }
        // GET: api/<TransaccionesGlobalController>
        [HttpGet]
        public async Task<List<TransaccionesGlobalDto>> Get()
        {
            return await _servicioTransaccionesGlobal.GetTransaccionesGlobales();
        }

        // GET api/<TransaccionesGlobalController>/5
        [HttpGet("{id}")]
        public async Task<TransaccionesGlobalDto> Get(int id)
        {
            return await _servicioTransaccionesGlobal.GetTransaccionesGlobal(id);
        }

        // POST api/<TransaccionesGlobalController>
        [HttpPost]
        public async Task<bool> Post([FromBody] TransaccionesGlobalDto value)
        {
            return await _servicioTransaccionesGlobal.CrearTransaccionGlobal(value);

        }

        // PUT api/<TransaccionesGlobalController>/5
        [HttpPut("{id}")]
        public TransaccionesGlobalDto Put([FromBody] TransaccionesGlobalDto id)
        {
            return _servicioTransaccionesGlobal.ActualizarTransaccionesGlobal(id).Result;
        }

        // DELETE api/<TransaccionesGlobalController>/5
        [HttpDelete("{id}")]
        public async Task<string> Delete(int id)
        {
            return await _servicioTransaccionesGlobal.EliminarTransaccionesGlobal(id);
        }

        [HttpGet("Clientes")]
        public async Task<List<ClientesGlobalDto>> GetClientes()
        {
            return await _servicioCliente.GetClientes();
        }
        [HttpGet("Vehiculos")]
        public async Task<List<VehiculosGlobalDto>> GetVehiculos()
        {
            return await _servicioAutomoviles.GetVehiculos();
        }
        [HttpGet("Concesionarios")]
        public async Task<List<ConcesionariosGlobalDto>> GetConsecionario()
        {
            return await _servicioConcesionarios.GetConcesionarios();
        }


    }
}
