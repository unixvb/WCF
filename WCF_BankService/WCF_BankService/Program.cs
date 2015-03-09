using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
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
            ServiceHost svcHost = new ServiceHost(typeof(BankService), new Uri("http://localhost/BankService"));
            ServiceMetadataBehavior smb = svcHost.Description.Behaviors.Find<ServiceMetadataBehavior>();
            if (smb == null)
                smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
            svcHost.Description.Behaviors.Add(smb);
            // Add MEX endpoint
            svcHost.AddServiceEndpoint(
              ServiceMetadataBehavior.MexContractName,
              MetadataExchangeBindings.CreateMexHttpBinding(),
              "mex"
            );
            svcHost.AddServiceEndpoint(typeof(IMetadataExchange), new WSHttpBinding(), "");
            svcHost.Open();
            Console.WriteLine("Press <ENTER> to Exit");
            Console.ReadLine();
            svcHost.Close();
        }
    }
}
