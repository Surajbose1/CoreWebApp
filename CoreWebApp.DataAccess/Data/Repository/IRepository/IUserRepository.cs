using CoreWebApp.Models;

namespace CoreWebApp.DataAccess.Data.Repository.IRepository
{
    public interface IUserRepository : IRepository<ApplicationUser>
    {
        void LockUser(string Id);
        void UnLockUser(string Id);
    }
}
