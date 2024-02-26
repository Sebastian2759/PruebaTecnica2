using Aplication.Dto;
using AutoMapper;
using Dominio.Entidades.VentasVehiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Mapper.Configuration
{
    public class ConfigurationMapperProfile:Profile
    {
      
        public ConfigurationMapperProfile()
        {
            CreateMap<TransaccionesGlobalDto, TransaccionesGlobalEntidad>().ReverseMap();
            CreateMap<ClientesGlobalDto, ClientesGlobalEntidad>().ReverseMap();
            CreateMap<VehiculosGlobalDto, VehiculosGlobalEntidad>().ReverseMap();
            CreateMap<ConcesionariosGlobalDto, ConcesionariosGlobalEntidad>().ReverseMap();
        }
    }
}
