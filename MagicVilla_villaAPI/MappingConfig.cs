using AutoMapper;
using MagicVilla_villaAPI.Models;
using MagicVilla_villaAPI.Models.DTO;

namespace MagicVilla_villaAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Villa, VillaDTO>();
            CreateMap<VillaDTO, Villa>();

            CreateMap<Villa, VillaCreateDTO>().ReverseMap();
            CreateMap<Villa, VillaUpadateDTO>().ReverseMap();


            CreateMap<VillaNumber, VillaNumberDTO>().ReverseMap();

            CreateMap<VillaNumber, VillaNumberCreateDTO>().ReverseMap();
            CreateMap<VillaNumber, VillaNumberUpdateDTO>().ReverseMap();
        }
    }
}
