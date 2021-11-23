using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_dont_net_e_commerce_practice.Controllers
{
    public class ProductController : Controller
    {
        //Injecting data from product and category repositories to controller and bring it here via readonly fields
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        //Constructor to inject reposiltories into controller
        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        //viewresult to return the combined data of product and category using a view model
        public ViewResult List(string category)
        {
            IEnumerable<Product> products;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                products = _productRepository.GetAllProduct.OrderBy(c => c.ProductId);
                currentCategory = "All Product";
            }
            else
            {
                products = _productRepository.GetAllProduct.Where(c => c.Category.CategoryName == category);

                currentCategory = _categoryRepository.GetAllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new ProductListViewModel
            {
                Products = products,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
                return NotFound();

            return View(product);
        }
    }
}
