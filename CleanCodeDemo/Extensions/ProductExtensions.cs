using CleanCodeDemo.Entity;
using CleanCodeDemo.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemo.Extensions
{
    public static class ProductExtensions
    {
        public static decimal GetPriceByCustomerType(this Product product , CustomerType customerType)
        {
            switch (customerType)
            {
                case CustomerType.Student:
                    return product.Price * (decimal)0.90;
                case CustomerType.Teacher:
                    return product.Price * (decimal)0.90;
                case CustomerType.Officer:
                    return product.Price * (decimal)0.90;
            }
                    return product.Price;
        }
    }
}
