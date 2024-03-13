using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens.observable.NotificationSystem.TopOfMind
{
    public class User
    {

        public string Name { get; }
        public bool IsSubscribedToProudect { get; }
        public bool IsSubscribedToOffer { get; }


        public User( string Name, bool IsSubscribedToProudect, bool IsSubscribedToOfferq)
        {
            this.Name = Name;
            this.IsSubscribedToOffer= IsSubscribedToOfferq;
            this.IsSubscribedToProudect = IsSubscribedToProudect;

        }

        public void Notify(Proudect proudect)
        {
            Console.WriteLine($"Notifying User: {Name} About New Proudect:{proudect.Name}");
        }
        public void Notify(Offer offer)
        {
            Console.WriteLine($"Notifying User: {Name} About New Offer:{offer.Message}");
        }


    }
}
