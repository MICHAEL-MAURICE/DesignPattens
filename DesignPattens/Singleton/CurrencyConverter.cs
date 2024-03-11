using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Singleton
{
    public class CurrencyConverter
    {
        private IEnumerable<ExchangeRate> _exchangeRates;

        private CurrencyConverter()
        {
            LoadExchangeRate();
        }

        private static CurrencyConverter _instance;
        private static object _lock= new();
        public static CurrencyConverter Instance
        {
            get
            {

                if (_instance == null)
                    lock (_lock)
                        if (_instance == null)
                            _instance = new ();
                    
                return _instance;
            }
        }
        private void LoadExchangeRate() { 
        
        Thread.Sleep(1000);
            _exchangeRates = new List<ExchangeRate>() {
             new ExchangeRate("USD" ,"EGP",30m),
             new ExchangeRate("EGP" ,"USD",1/30m),

            };
        }


        public decimal Convert(string baseCurrency, string TargetCurrency, decimal amount)
        {
            var RateValue = _exchangeRates.FirstOrDefault(Cur => Cur.baseCurrency == baseCurrency && Cur.TargetCurrency == TargetCurrency)?.Rate;

            if (RateValue != null)
            {
                return (decimal)(amount * RateValue);
            }
            return 0;
        }
    }
}
