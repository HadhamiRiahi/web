using AutoMapper;
using web.Controllers.resources;
using web.Models;

namespace web.Mapping
{
    public class MappingProfile : Profile
    {
        
    
        public MappingProfile()
        {
            CreateMap<product, productResource>();
        }
    }
}