using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens.observable.NotificationSystem.EnhanceSolution
{
    public interface ISubscriper
    {
        public void Notify(string Message);
    }
}
