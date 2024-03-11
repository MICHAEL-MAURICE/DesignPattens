using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_pattern.Strategy_Pattern
{
    #region Duck class

    public abstract class Duck
    {
        private int _id = 0;
        private string _name = "";
        private static int counter = 0;
        public IFlatbehaviour myFly;
        public Duck()
        {
            this._id = counter++;
            this._name = $"Hey iam {_id} duck ";
            this.myFly = new FlyWithtwowings();
        }
        public string swim()
        {
            return "Hi iam swimming";
        }

        public abstract string display();


        public void perform()
        {

            Console.WriteLine($"Hi iam {this._name}");
            Console.WriteLine(this.swim());
            Console.WriteLine(this.display());
            Console.WriteLine(this.myFly.fly());
            Console.WriteLine("___________________________________________________________________");
        }
    }


    #endregion
}
