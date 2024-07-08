using CleanCodeDemo.Entity.Dto;
using CleanCodeDemo.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemo.Adapter
{
    public class CentralBankAdapter : IBankService
    {
      

        public decimal ConvertRate(CurrencyRate currencyRate)
        {
            CentralBankService centralBankService = new CentralBankService();
            return centralBankService.ConvertRate(currencyRate);
        }
    }
}
