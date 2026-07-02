using CampusOs.Dataaccess;
using CampusOs.IRepositoryContracts;

namespace CampusOs.Repository
{
    public class ApplicantRepo : IRepository<Applicant>
    {
        private readonly ApplicationDbContext applicationDbContext;
        public ApplicantRepo(ApplicationDbContext _applicationDbContext)
        {
            applicationDbContext = _applicationDbContext;
        }

        public async Task<bool> AddAsync(Applicant obj)
        {
            try
            {
                applicationDbContext.Add(obj);
                await applicationDbContext.SaveChangesAsync();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public Task<bool> DeleteAsync(Applicant obj)
        {
            throw new NotImplementedException();
        }

        public Task<Applicant> GetAsync(Applicant obj)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Applicant obj)
        {
            throw new NotImplementedException();
        }
    }
}
