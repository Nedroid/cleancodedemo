using CleanCodeDemo.Entity.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemo.Service
{
    public interface IBankService
    {
        decimal ConvertRate(CurrencyRate currencyRate);
    }
}
