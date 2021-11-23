using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_dont_net_e_commerce_practice.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        //method gets categories data from the database and return to controller
        public IEnumerable<Category> GetAllCategories => _appDbContext.Categories;
    }
}
