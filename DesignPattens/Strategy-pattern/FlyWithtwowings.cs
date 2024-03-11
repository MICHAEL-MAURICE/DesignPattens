﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_pattern.Strategy_Pattern
{
    #region FlyWithtwowings
    public class FlyWithtwowings : IFlatbehaviour
    {
        public string fly()
        {
            return "Iam Flying With two wings";
        }
    }

    #endregion
}
