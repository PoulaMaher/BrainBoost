using AutoMapper;
using BrainBoost_API.DTOs.Course;
using BrainBoost_API.DTOs.Review;
using BrainBoost_API.Models;

namespace BrainBoost_API.Repositories.Inplementation
{
    public class CourseRepository : Repository<Course> , ICourseRepository
    {
        private readonly ApplicationDbContext Context;
        private readonly IMapper mapper;

        public CourseRepository(ApplicationDbContext context,IMapper mapper) : base(context)
        {
            this.Context = context;
            this.mapper = mapper;
        }

        public CourseDetails getCrsDetails(Course crs,List<Review> review)
        {
            if(crs!=null)
            {
                CourseDetails crsDetails = mapper.Map<CourseDetails>(crs);
               
                crsDetails.Review= mapper.Map<IEnumerable<ReviewDTO>>(review).ToList();
                crsDetails.WhatToLearn= mapper.Map<IEnumerable<WhatToLearnDTO>>(crs.WhatToLearn).ToList();
                crsDetails.Fname = crs.Teacher.Fname;
                crsDetails.Lname = crs.Teacher.Lname;
                
                return crsDetails;
            }         
            return new CourseDetails();
        }
    }
}
