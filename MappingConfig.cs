using AutoMapper;
using Web_Minimal_API.Models;
using Web_Minimal_API.Models.DTO;

namespace Web_Minimal_API
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Coupon, CouponCreateDto>().ReverseMap();
            CreateMap<Coupon, CouponDTO>().ReverseMap();

        }
    }
}
