using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_dont_net_e_commerce_practice.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        //Method gets all the products from the database in product table
        public IEnumerable<Product> GetAllProduct
        {
            get
            {
                return _appDbContext.Products.Include(c => c.Category);
            }
        }

        //method gets all the prodcuts that are on sale from the database product table
        public IEnumerable<Product> GetProductOnSale
        {
            get
            {
                return _appDbContext.Products.Include(c => c.Category).Where(p => p.IsOnSale);
            }
        }

        //method gets specific product with requested productId from the database in product table
        // if the product for the corresponding productId is not found the null is returned
        public Product GetProductById(int productId)
        {
            return _appDbContext.Products.FirstOrDefault(c => c.ProductId == productId);
        }
    }
}
