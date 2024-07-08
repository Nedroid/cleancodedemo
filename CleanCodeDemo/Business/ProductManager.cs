using CleanCodeDemo.Entity;
using CleanCodeDemo.Extensions;
using CleanCodeDemo.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemo.Business
{
    public class ProductManager : IproductService
    {
        IBankService _bankService;
        public ProductManager(IBankService bankService)
        {
            _bankService = bankService;

        }
        public void Sell(Product product, Customer customer)
        {
            decimal price = product.GetPriceByCustomerType(customer.Type);

            
          price=  _bankService.ConvertRate(new Entity.Dto.CurrencyRate
            {
                Currency = 1,
                Price = 1000
            });
            Console.WriteLine(price);
            Console.ReadLine();
        }
        
    }    
}
