using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_pattern.Strategy_Pattern
{
    public class Duck1 : Duck
    {

        public Duck1()
        {

            this.myFly = new FlyWithtwowings();
        }
        public override string display()
        {
            return $"iam Duck1 ";
        }
    }
}
