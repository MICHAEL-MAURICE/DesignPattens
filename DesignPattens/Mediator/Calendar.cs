using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_pattern.Mediator
{
    public class Calendar
    {
        internal int  getDay()
        {
            return DayOfWeek();
        }


        private  int DayOfWeek()
        {
            Random rnd = new Random();
            return  rnd.Next(1, 7);
        }
    }
}
