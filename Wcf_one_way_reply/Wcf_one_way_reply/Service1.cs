using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace Wcf_one_way_reply
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Reply : IReply
    {

        public void FastReply()
        {
            Thread.Sleep(5000);
        }

        public void SlowReply()
        {
            Thread.Sleep(5000);
        }
    }
}
