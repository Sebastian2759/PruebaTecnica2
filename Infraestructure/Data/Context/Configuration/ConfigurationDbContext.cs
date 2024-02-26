using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Data.Context.Configuration
{
    public class ConfigurationDbContext
    {
        private readonly string _connectionString;
        public ConfigurationDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        public string GetConnectionString()
        {
            return _connectionString;
        }
        public VentasVehiculosContext GetVentasVehiculosContext()
        {
            var options = new DbContextOptionsBuilder<VentasVehiculosContext>();
            options.UseSqlServer(_connectionString);

            return new VentasVehiculosContext(options.Options);

        }

    }
}
