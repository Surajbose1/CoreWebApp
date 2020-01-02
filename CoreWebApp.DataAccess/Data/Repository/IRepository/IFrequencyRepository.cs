using CoreWebApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CoreWebApp.DataAccess.Data.Repository.IRepository
{
    public interface IFrequencyRepository : IRepository<Frequency>
    {
        IEnumerable<SelectListItem> GetFrequencyListForDropDown();

        void Update(Frequency frequency);
    }
}
