using _4_AutoMapperWithDTO.Models;
using _4_AutoMapperWithDTO.Models.DTO;
using AutoMapper;


namespace _4_AutoMapperWithDTO
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
