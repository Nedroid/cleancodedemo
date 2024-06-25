using CleanCodeDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemo.Business
{
    public interface IproductService
    {
        void Sell(Product product,Customer customer); 
    }
}
