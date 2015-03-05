using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Service_dll
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IMyMath
    {

        public MathResult Total(int x, int y)
        {
            MathResult res = new MathResult();
            res.sum = x + y;
            res.subtr = x - y;
            if (y != 0)
                res.div = x / y;
            res.mult = x * y;
            return res;
        }
    }
}
