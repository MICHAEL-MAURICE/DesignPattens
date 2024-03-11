using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_pattern.Strategy_Pattern
{
    public class Duck2 : Duck
    {

        public Duck2()
        {

            this.myFly = new Nofly();
        }

        public override string display()
        {
            return $"iam Duck2 ";
        }
    }
}
