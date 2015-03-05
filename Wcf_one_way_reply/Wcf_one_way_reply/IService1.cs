using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcf_one_way_reply
{
    [ServiceContract]
    public interface IReply
    {
        [OperationContract(IsOneWay = true)]
        void FastReply();
        [OperationContract]
        void SlowReply();
    }
}
