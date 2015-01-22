using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyDiskInfoServer
{
    [ServiceContract]
    public interface IMyDiskInfo
    {
        [OperationContract]
        string FreeSpace(string DiskName);
        [OperationContract]
        string TotalSpace(string DiskName);
    }

    public class MyDiskInfo : IMyDiskInfo
    {
        string IMyDiskInfo.FreeSpace(string DiskName)
        {
            char name = DiskName[0];
            DriveInfo[] allDrivers = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrivers)
            {
                if (d.Name == Convert.ToString(name).ToUpper() + ":\\")
                {
                    return Convert.ToString(d.TotalFreeSpace);
                }
            }
            return "Wrong disk!";
        }

        string IMyDiskInfo.TotalSpace(string DiskName)
        {
            char name = DiskName[0];
            DriveInfo[] allDrivers = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrivers)
            {
                if (d.Name == Convert.ToString(name).ToUpper() + ":\\")
                {
                    return Convert.ToString(d.TotalSize);
                }
            }
            return "Wrong disk!";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(MyDiskInfo));
            try
            {
                host.Open();
                Console.WriteLine("press <ENTER>\n");
                Console.ReadLine();
                host.Close();
            }
            catch (Exception ex)
            {
                host.Abort();
                Console.WriteLine(ex);
                Console.ReadKey();
            }   
        }
    }
}
