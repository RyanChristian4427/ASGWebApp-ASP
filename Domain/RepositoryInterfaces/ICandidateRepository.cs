using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.RepositoryInterfaces
{
    public interface ICandidateRepository
    {
        //CRUD
        
        Task<PaginatedList<User>> Find(FilteredPageRequest filteredPageRequest);
        Task<Candidate> FindByUserId(long id);
        Task<User> FindByEmail(string email);
    }
}