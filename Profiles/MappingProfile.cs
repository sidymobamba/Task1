using AutoMapper;
using Task1.Entities;
using Task1.Models;

namespace Task1.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<JsonClass, DbClass>()
                .ForMember(dest => dest.Field1, opt => opt.MapFrom(src => src.Proprieta1))
                .ForMember(dest => dest.Field2, opt => opt.MapFrom(src => src.Proprieta2))
                .ForMember(dest => dest.Field3, opt => opt.MapFrom(src => src.Proprieta3));
        }
    }
}
