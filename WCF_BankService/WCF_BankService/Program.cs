using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF_BankService
{
    [ServiceContract]
    public interface IBankSerevice
    {
        [OperationContract]
        void ToDeposit(double sum);
        [OperationContract]
        double GetBalance();
    }

    public class BankService : IBankSerevice
    {
        static int id = 0;
        public double Balance;
        public BankService()
        {
            ++id;
            Console.WriteLine(id + " was created");
        }
        public void ToDeposit(double sum)
        {
            Balance += sum;
        }

        public double GetBalance()
        {
            return Balance;
        }
    }
 

    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(BankService));
            sh.Open();
            Console.WriteLine("Press <ENTER> to Exit");
            Console.ReadLine();
            sh.Close();
        }
    }
}
