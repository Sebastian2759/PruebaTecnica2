using Aplication.Mapper.Configuration;
using Aplication.Mapper.Interfaces;
using Aplication.Mapper.VentaAutomoviles;
using Aplication.Servicios.VentaAutomoviles;
using Aplication.Servicios.VentaAutomoviles.Interfaces;
using AutoMapper;
using Dominio.Interfaces;
using Infraestructure.Data.Context;
using Infraestructure.Data.Context.Configuration;
using Infraestructure.Repositorio;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infraestructure.Api
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
           

            services.AddDbContext<VentasVehiculosContext>(options => options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));
            var connectionString = _configuration.GetConnectionString("DefaultConnection");
            services.AddSingleton(new ConfigurationDbContext(connectionString));
            
            //adicionar mapper
            services.AddAutoMapper(typeof(ConfigurationMapperProfile));


            //Services del proyecto
            services.AddSingleton<IRepositorioTransaccionesGlobal, RepositorioTransaccionesGlobal>();
            services.AddSingleton<IServicioTransaccionesGlobal, ServicioTransaccionesGlobal>();
            services.AddSingleton<IMapperTransaccionesGlobal, MapperTransaccionesGlobal>();
            services.AddSingleton<IRepositorioVehiculoGlobal, RepositorioVehiculoGlobal>();
            services.AddSingleton<IServicioAutomoviles, ServicioAutomoviles>();
            services.AddSingleton<IMapperVehiculo, MapperVehiculos>();
            services.AddSingleton<IRepositorioClienteGlobal, RepositorioClienteGlobal>();
            services.AddSingleton<IServicioClientes, ServicioCliente>();
            services.AddSingleton<IMapperClientes, MapperClientes>();
            services.AddSingleton<IRepositorioConseccionarioGlobal, RepositorioConseccionarioGlobal>();
            services.AddSingleton<IServicioConsecionario, ServicioConsecionarios>();
            services.AddSingleton<IMapperConcesionarios, MapperConcesionarios>();
            services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin",
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:4200")
                               .AllowAnyHeader()
                               .AllowAnyMethod();
                    });
            });


        }

    }
}
