using BathBombMVC.DataAccess.Data;
using BathBombMVC.DataAccess.Repository.IRepository;
using BathBombMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BathBombMVC.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository 
    {
        private ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db): base(db)
        {
            _db= db;
        }
        
        public void Update(Category obj)
        {
        _db.Categories.Update(obj);
        }
    }
}
