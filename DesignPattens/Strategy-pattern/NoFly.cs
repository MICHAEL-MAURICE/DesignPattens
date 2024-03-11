using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_pattern.Strategy_Pattern
{
    public class Nofly : IFlatbehaviour
    {
        public string fly()
        {
            return "Iam not Flying";
        }
    }
}
