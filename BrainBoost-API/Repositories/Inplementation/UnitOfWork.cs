using BrainBoost_API.Repositories.Inplementation;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using BrainBoost_API.Repositories.Interfaces;

namespace BrainBoost_API.Repositories.Inplementation
{
    public class UnitOfWork<T> : IUnitOfWork
    {
        private readonly ApplicationDbContext Context;
        public IVideoRepository VideoRepository { get; private set; }
        public IQuizRepository QuizRepository { get; private set; }
        public IStudentRepository StudentRepository { get; private set; }
        public ICourseRepository CourseRepository { get; private set; }
        public ITeacherRepository TeacherRepository { get; private set; }
        public IReviewRepository ReviewRepository { get; private set; }
        public ISubscriptionRepository SubscriptionRepository { get; private set; }
        public IFacebookUserRepository FacebookUserRepository { get; private set; }
        public IPlanRepository PlanRepository { get; private set; }
        public IEnrollmentRepository EnrollmentRepository { get; private set; }
        public ICertificateRepository CertificateRepository { get; private set; }
        public ICategoryRepository CategoryRepository { get; private set; }
        public IAnswerRepository AnswerRepository { get; private set; }
        public IQuestionRepository QuestionRepository { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            this.Context = context;
        }

        
    }
}
