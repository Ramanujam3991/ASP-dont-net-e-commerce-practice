using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_dont_net_e_commerce_practice.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
