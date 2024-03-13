using DesignPattens.observable.NotificationSystem.EnhanceSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens.observable.NotificationSystem.EnhanceSolution
{
    public class OnlineMarketPlace2
    {
        private  Dictionary<EventTypes, List<ISubscriper>> Subscriper;
        private List<Proudect2> Proudects;
        private List<Offer2> Offers;

        public OnlineMarketPlace2()
        {
          Subscriper=new Dictionary<EventTypes, List<ISubscriper>>();
           initSubscriperEvents();
         Proudects = new List<Proudect2>();
            Offers = new List<Offer2>();
        }

        private void initSubscriperEvents()
        {
            Subscriper.Add(EventTypes.New_Offer, new List<ISubscriper>());
            Subscriper.Add(EventTypes.New_Proudect, new List<ISubscriper>());
            Subscriper.Add(EventTypes.Opening_Job, new List<ISubscriper>());
        }

        public void Subscripe (EventTypes eventTypes,ISubscriper subscriper)
        {
          Subscriper[eventTypes].Add(subscriper);

        }

        public void UnSubscripe(EventTypes eventType,ISubscriper subscriper ) {
            Subscriper[eventType].Remove(subscriper);   
        }


        public void addProudect(Proudect2 proudect)
        {
            Proudects.Add(proudect);
            notifySubscriper(EventTypes.New_Proudect,"New Proudect Added");

        }
        public void addOffer(Offer2 offer)
        {
            Offers.Add(offer);
            notifySubscriper(EventTypes.New_Offer," New Offer Added");

        }
        private void notifySubscriper(EventTypes eventType,string Message)
        {
            Subscriper[eventType].ForEach(Subscriper => Subscriper.Notify(Message)) ;
          
        }
        
    }
}
