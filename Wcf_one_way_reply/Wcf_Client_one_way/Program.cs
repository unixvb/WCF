using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wcf_Client_one_way.ServiceReference1;

namespace Wcf_Client_one_way
{
    class Program
    {
        static void Main(string[] args)
        {
            ReplyClient proxy = new ReplyClient();
            proxy.FastReply();
            //proxy.SlowReply();

            Console.Write("Hi. (:\n\n\n");
        }
    }
}
