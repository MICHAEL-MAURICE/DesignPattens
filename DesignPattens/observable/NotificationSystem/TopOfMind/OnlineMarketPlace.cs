using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens.observable.NotificationSystem.TopOfMind
{
    public class OnlineMarketPlace
    {
        private List<User> Users;
        private List<Proudect> Proudects;
        private List<Offer> Offers;

        public OnlineMarketPlace()
        {
            Users = new List<User>();
            Proudects = new List<Proudect>();
            Offers = new List<Offer>();
        }

        public void addUser(User User)
        {
            Users.Add(User);

        }

        public void addProudect(Proudect proudect)
        {
            Proudects.Add(proudect);
            notifyUser(proudect);

        }
        public void addOffer(Offer offer)
        {
            Offers.Add(offer);
            notifyUser(offer);

        }
        private void notifyUser(Offer offer)
        {
            Users.ForEach(user => { if (user.IsSubscribedToProudect) user.Notify(offer); }) ;
          
        }
        private void notifyUser(Proudect proudect)
        {
            Users.ForEach(user => { if (user.IsSubscribedToProudect) user.Notify(proudect); });

        }
    }
}
