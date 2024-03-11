using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_pattern.Mediator
{
    public class CoffeeMachine
    {
        private readonly Mediator _mediator;

        public CoffeeMachine(Mediator mediator)
        {
            _mediator = mediator;
        }

        internal void Start()
        {
            System.Console.WriteLine("Preparing Coffee");

            var day =_mediator.getDay();
            if (day == 3)
            {
                System.Console.WriteLine("Adding Suger");

            }
            System.Console.WriteLine("Finished Preparing Coffee");

            _mediator.Transport();
        }
    }
}
