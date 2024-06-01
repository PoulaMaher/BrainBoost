using AutoMapper;
using BrainBoost_API.DTOs.Enrollment;
using BrainBoost_API.DTOs.Subscription;
using BrainBoost_API.Models;

namespace BrainBoost_API.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<SubscriptionDto, subscription>().ReverseMap();
            CreateMap<EnrollmentDto, Enrollment>().ReverseMap();

        }
    }
}
