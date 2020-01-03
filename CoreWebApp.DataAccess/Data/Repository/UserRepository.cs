using CoreWebApp.DataAccess.Data.Repository.IRepository;
using CoreWebApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWebApp.DataAccess.Data.Repository
{
    public class UserRepository : Repository<ApplicationUser>, IUserRepository
    {
        private readonly ApplicationDbContext _db;
        public UserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void LockUser(string Id)
        {
            var user = _db.ApplicationUser.Find(Id);
            user.LockoutEnd = DateTime.Now.AddYears(1000);
            _db.SaveChanges();
        }

        public void UnLockUser(string Id)
        {
            var user = _db.ApplicationUser.Find(Id);
            user.LockoutEnd = DateTime.Now;
            _db.SaveChanges();
        }
    }
}
