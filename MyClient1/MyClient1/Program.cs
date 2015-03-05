using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MyClient1
{
    [ServiceContract]
    public interface IMyMath
    {
        [OperationContract]
        int Add(int a, int b);
    }

    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<IMyMath> factory = new ChannelFactory<IMyMath>(new WSHttpBinding(), new EndpointAddress("http://localhost/MyMath/Epl"));
            IMyMath channel = factory.CreateChannel();
            int result = channel.Add(12, 15);
            Console.WriteLine("res = " + result);
            Console.WriteLine("\npress <ENTER>\n");
            Console.ReadLine();
            factory.Close();
        }
    }
}
