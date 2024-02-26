using Dominio.Entidades.VentasVehiculos;
using Dominio.Interfaces;
using Infraestructure.Data.Context;
using Infraestructure.Data.Context.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Infraestructure.Repositorio
{
    public class RepositorioTransaccionesGlobal : IRepositorioTransaccionesGlobal
    {
        private readonly ConfigurationDbContext _ConfigurationDbContext;
        public RepositorioTransaccionesGlobal(ConfigurationDbContext configurationDbContext)
        {
            _ConfigurationDbContext = configurationDbContext;
        }
        public async Task<TransaccionesGlobalEntidad> ActualizarTransaccionesGlobal(TransaccionesGlobalEntidad entidad)
        {
            try
            {
                using (var db = _ConfigurationDbContext.GetVentasVehiculosContext())
                {
                    var busqueda = db.TransaccionesGlobal.Where(x => x.TransaccionID == entidad.TransaccionID).FirstOrDefault();
                    if (!busqueda.Equals(null))
                    {
                        // Desconectar la entidad original del contexto
                        db.Entry(busqueda).State = EntityState.Detached;


                        db.Entry(entidad).State = EntityState.Modified;
                        await db.SaveChangesAsync();
                        return entidad;

                    }
                    else
                    {
                        return new TransaccionesGlobalEntidad();
                    }
                }
            }
            catch (Exception e)
            {

                throw e.InnerException;
            }
           
        }


        public async Task<bool> CrearTransaccionGlobal(TransaccionesGlobalEntidad entidad)
        {
            try
            {
                using (var db = _ConfigurationDbContext.GetVentasVehiculosContext())
                {
                    db.TransaccionesGlobal.Add(entidad);
                    await db.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception e)
            {

                throw e.InnerException;
            }
           
        }

        public async Task<string> EliminarTransaccionesGlobal(int transaccionID)
        {
            using (var db = _ConfigurationDbContext.GetVentasVehiculosContext())
            {
                var busqueda = db.TransaccionesGlobal.Where(x => x.TransaccionID == transaccionID).FirstOrDefaultAsync();
                if (!busqueda.Equals(null))
                {
                    db.TransaccionesGlobal.Remove(busqueda.Result);
                    await db.SaveChangesAsync();
                    return "Se actualizo Correctamente";
                }
                else
                { 
                    return "No Se actualizo Correctamente";
                }
            }
        }

        public async Task<TransaccionesGlobalEntidad> GetTransaccionesGlobal(int transaccionID)
        {
            try
            {
                using (var db = _ConfigurationDbContext.GetVentasVehiculosContext())
                {
                    var result = db.TransaccionesGlobal.Where(x => x.TransaccionID == transaccionID).FirstOrDefaultAsync();
                    if (!result.Result.Equals(null))
                    {
                        return await result;
                    }
                    else
                    {
                        return null;
                    }
                  
                }
            }
            catch (Exception e)
            {

                throw e.InnerException;
            }
           
        }

        public List<TransaccionesGlobalEntidad> GetTransaccionesGlobales()
        {
            try
            {
                using (var db = _ConfigurationDbContext.GetVentasVehiculosContext())
                {
                    var result = db.TransaccionesGlobal
                        .Include(t => t.Vehiculo)
                        .Include(t => t.Cliente)
                        .Include(t => t.Concesionario)
                        .ToList();
                    return db.TransaccionesGlobal
                        .Include(t => t.Vehiculo)
                        .Include(t => t.Cliente)
                        .Include(t => t.Concesionario)
                        .ToList();
                }
            }
            catch (Exception e)
            {

                throw e.InnerException;
            }

        }
        
    }
}
