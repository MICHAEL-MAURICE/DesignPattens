using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens.observable.NotificationSystem.TopOfMind
{
    public class Offer
    {

        public string Message { get;}

        public Offer(string Message)
        {
                this.Message = Message;
        }
    }
}
