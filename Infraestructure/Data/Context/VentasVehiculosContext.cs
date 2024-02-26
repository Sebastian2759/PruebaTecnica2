using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades.VentasVehiculos;
namespace Infraestructure.Data.Context
{
    public class VentasVehiculosContext:DbContext
    {
        public VentasVehiculosContext(DbContextOptions<VentasVehiculosContext> options):base(options)
        {

        }
        public DbSet<InformacionGlobalEntidad> GlobalEntidad { get; set;}
        public DbSet<ClientesGlobalEntidad> ClientesGlobal { get; set; }
        public DbSet<ConcesionariosGlobalEntidad> ConcesionariosGlobal { get; set; }
        public DbSet<TransaccionesGlobalEntidad> TransaccionesGlobal { get; set; }
        public DbSet<VehiculosGlobalEntidad> VehiculosGlobal { get; set; }


    }
}
