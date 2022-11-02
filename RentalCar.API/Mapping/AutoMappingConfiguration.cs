using AutoMapper;
using RentalCar.API.Models;
using RentalCar.Model.Models;

namespace RentalCar.API.Mapping
{
    public class AutoMappingConfiguration : Profile
    {
        public AutoMappingConfiguration()
        {
            CreateMap<User, UserProfile>()
                .ForMember(
                    dest => dest.Address,
                    option => option.MapFrom(src => src.Location.Address)
                )
                .ForMember(
                    dest => dest.Ward,
                    option => option.MapFrom(src => src.Location.Ward.Name)
                )
                .ForMember(
                    dest => dest.District,
                    option => option.MapFrom(src => src.Location.Ward.District.Name)
                );
        }
    }
}