using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_pattern.Mediator
{
    public class MovingRobot
    {
        private readonly Mediator _mediator;
        public MovingRobot(Mediator mediator)
        {
            _mediator = mediator;
        }

        internal void Transport()
        {
            System.Console.WriteLine("Transporting Coffee ");

            _mediator.AlarmRing();
            _mediator.OpenWindow();
        }
    }
}
