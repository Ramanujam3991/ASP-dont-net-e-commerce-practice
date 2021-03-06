using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_dont_net_e_commerce_practice.ViewModels
{
    public class ProductListViewModel
    {
        //data from products
        public IEnumerable<Product> Products { get; set; }

        //data fro category
        public string CurrentCategory { get; set; }
    }
}
