using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Singleton
{
    public class ExchangeRate
    {

        public ExchangeRate( string baseCurrency,string TargetCurrency,decimal Rate)
        {
            this.baseCurrency = baseCurrency;
            this.TargetCurrency = TargetCurrency;
            this.Rate = Rate;

        }
        public string  baseCurrency { get;  }
        public string TargetCurrency { get; }
        public decimal Rate { get; }


    }
}
