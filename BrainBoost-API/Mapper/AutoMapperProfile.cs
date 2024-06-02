using AutoMapper;
using BrainBoost_API.DTOs.Course;
using BrainBoost_API.DTOs.Review;
using BrainBoost_API.DTOs.Subscription;
using BrainBoost_API.Models;

namespace BrainBoost_API.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<SubscriptionDto, subscription>().ReverseMap();
            CreateMap<CourseDetails, Course>().ReverseMap();
            CreateMap<ReviewDTO, Review>().ReverseMap();
            CreateMap<WhatToLearnDTO, WhatToLearn>().ReverseMap();




        }
    }
}
