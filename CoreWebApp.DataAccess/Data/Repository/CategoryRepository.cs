using CoreWebApp.DataAccess.Data.Repository.IRepository;
using CoreWebApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoreWebApp.DataAccess.Data.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetCategoryListForDropDown()
        {
            return _db.Category.Select(x=> new SelectListItem() { Text = x.Name, Value=x.Id.ToString() });
        }

        public void Update(Category category)
        {
            var dbCategory = _db.Category.FirstOrDefault(x => x.Id == category.Id);
            dbCategory.Name = category.Name;
            dbCategory.DisplayOrder = category.DisplayOrder;

            _db.SaveChanges();
        }
    }
}
