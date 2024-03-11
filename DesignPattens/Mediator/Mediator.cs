using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_pattern.Mediator
{
    public class Mediator
    {
        private  Alarm _alarm;
        private  Calendar _calendar;
        private  CoffeeMachine _coffeeMachine;
        private  MovingRobot _movingRobot;
        private  SmartWindow _smartWindow;




        public Mediator( )
        {
            
        }

        public void send(Alarm alarm, Calendar calendar, CoffeeMachine coffeeMachine, MovingRobot movingRobot, SmartWindow smartWindow)
        {
            _alarm = alarm;
            _calendar = calendar;
            _coffeeMachine = coffeeMachine;
            _movingRobot = movingRobot;
            _smartWindow = smartWindow;

        }

        internal void AlarmRing()
        {
            _alarm.Ring();
        }

        internal int getDay()
        {
           return _calendar.getDay();
        }

        internal void MakeCoffee()
        {
            _coffeeMachine.Start();
        }

        internal void OpenWindow()
        {
            _smartWindow.Open();
        }

        internal void Transport()
        {
            _movingRobot.Transport();
        }
    }
}
