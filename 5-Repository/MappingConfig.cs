using _5_Repository.Models;
using _5_Repository.Models.DTO;
using AutoMapper;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _5_Repository
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDTO>();
            CreateMap<VillaDTO, Villa>();

            CreateMap<Villa, VillaCreateDTO>().ReverseMap();
            CreateMap<Villa, VillaUpdateDTO>().ReverseMap();
        }
    }
}
