using System;

namespace CoreWebApp.DataAccess.Data.Repository.IRepository
{
    public interface IUnitOfWork:IDisposable
    {
        ICategoryRepository Category { get; }

        IFrequencyRepository Frequency { get; }

        IServiceRepository Service { get; }

        IUserRepository User { get; }
        void Save();
    }
}
