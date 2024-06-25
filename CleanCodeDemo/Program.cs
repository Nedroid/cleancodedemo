using CleanCodeDemo.Adapter;
using CleanCodeDemo.Business;
using CleanCodeDemo.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IproductService productService = new ProductManager(new CentralBankAdapter());
            productService.Sell(new Entity.Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 1000
            }, new Entity.Customer
            {
                Id = 1,
                Name = "Engin",
                isStudent = true
            });
            
        }
    }
}
