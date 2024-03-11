using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_pattern.Mediator
{
    public class Alarm
    {
        private Mediator _mediator;
        public Alarm(Mediator mediator)
        {
            _mediator = mediator;
        }
       public void Snooz()
        {
            var day = _mediator.getDay();

            if (day != 1 || day != 7)
            {
                _mediator.MakeCoffee();
            }

        }


        public void Ring()
        {
            System.Console.WriteLine("Ringing");

        }


    }
}
