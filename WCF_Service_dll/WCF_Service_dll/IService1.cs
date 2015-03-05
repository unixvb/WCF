using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Service_dll
{
    [DataContract]
    public class MathResult
    {
        [DataMember]
        public double sum;
        [DataMember]
        public double subtr;
        [DataMember]
        public double div;
        [DataMember]
        public double mult;
    }

    [ServiceContract]
    public interface IMyMath
    {
        [OperationContract]
        MathResult Total(int x, int y);
    }
}
