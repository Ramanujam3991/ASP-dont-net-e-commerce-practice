using ASP_dont_net_e_commerce_practice.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_dont_net_e_commerce_practice.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _ProductRepository;

        public HomeController(IProductRepository ProductRepository)
        {
            _ProductRepository = ProductRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ProductOnSale = _ProductRepository.GetProductOnSale
            };

            return View(homeViewModel);
        }
    }
}
