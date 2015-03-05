using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCF_BankClient.ServiceReference1;

namespace WCF_BankClient
{
    class Program
    {
        static void Main(string[] args)
        {
            BankSereviceClient proxy = new BankSereviceClient();
            Console.WriteLine("Enter deposit sum: ");
            double sum = Convert.ToDouble(Console.ReadLine());
            double result = 0;
            while (sum > 0)
            {
                proxy.ToDeposit(sum);
                result = proxy.GetBalance();
                Console.WriteLine("Deposit #" + result);
                Console.WriteLine("Enter deposit sum: ");
                sum = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Press <ENTER> to Exit");
            Console.ReadLine();
        }
    }
}
