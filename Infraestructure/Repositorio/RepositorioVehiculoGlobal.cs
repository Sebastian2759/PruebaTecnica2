using Dominio.Entidades.VentasVehiculos;
using Dominio.Interfaces;
using Infraestructure.Data.Context.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositorio
{
    public class RepositorioVehiculoGlobal: IRepositorioVehiculoGlobal
    {
        private readonly ConfigurationDbContext _context;
        public RepositorioVehiculoGlobal(ConfigurationDbContext context)
        {
            _context = context;
        }
        public async Task<List<VehiculosGlobalEntidad>> GetVehiculos()
        {
            using (var db = _context.GetVentasVehiculosContext())
            {
                return await db.VehiculosGlobal.ToListAsync();
            }
        }
    }
}
