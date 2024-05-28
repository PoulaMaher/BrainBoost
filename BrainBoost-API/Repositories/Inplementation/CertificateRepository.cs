using BrainBoost_API.Models;

namespace BrainBoost_API.Repositories.Inplementation
{
    public class CertificateRepository : Repository<Certificate> , ICertificateRepository
    {
        private readonly ApplicationDbContext Context;
        public CertificateRepository(ApplicationDbContext context) : base(context)
        {
            this.Context = context;
        }
    }
}
