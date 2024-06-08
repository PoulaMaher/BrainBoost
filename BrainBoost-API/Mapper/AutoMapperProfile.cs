using AutoMapper;
using BrainBoost_API.DTOs.Course;
using BrainBoost_API.DTOs.Review;
using BrainBoost_API.DTOs.Enrollment;
using BrainBoost_API.DTOs.Subscription;
using BrainBoost_API.Models;
using BrainBoost_API.DTOs.Quiz;
using BrainBoost_API.DTOs.Question;
using BrainBoost_API.DTOs.Answer;
<<<<<<< HEAD
=======
using BrainBoost_API.DTOs;
>>>>>>> 756686e55193e3b79a7e14c5469c3d8f252f42cd

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
            CreateMap<EnrollmentDto, Enrollment>().ReverseMap();
            CreateMap<QuizDTO, Quiz>().ReverseMap();
            CreateMap<QuestionDTO, Question>().ReverseMap();
            CreateMap<AnswerDTO, Answer>().ReverseMap();
<<<<<<< HEAD
            CreateMap<CertificateDTO, Course>().ReverseMap();
=======
>>>>>>> 756686e55193e3b79a7e14c5469c3d8f252f42cd
            CreateMap<Course, CourseCardDataDto>();
            CreateMap<Teacher, CourseCardTeacherDataDto>();

        }
    }
}
