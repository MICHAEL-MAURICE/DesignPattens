using DesignPattens.observable.NotificationSystem.TopOfMind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens.observable.NotificationSystem.EnhanceSolution
{
    public class Customer:ISubscriper
    {

        public string Name { get; }

        public Customer(string Name)
        {
            this.Name = Name;

        }
        public void Notify(string Message)
        {
            Console.WriteLine($"Notifying User: {Name} About New {Message}");
        }
    }
}
