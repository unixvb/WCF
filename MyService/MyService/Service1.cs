using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace MyService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            this.MyLog("Service starded");
        }

        protected override void OnStop()
        {
            this.MyLog("Service stoped");
        }

        private void MyLog(string msg)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter("svclog.txt", true);
                msg += "\t\t";
                msg += DateTime.Now.ToLongTimeString();
                sw.WriteLine(msg);
            }
            catch (Exception ex)
            {
                StreamWriter error = new StreamWriter("error.txt", true);
                error.WriteLine(ex.Message);
                error.Close();
            }
            finally
            {
                sw.Close();
            }
        }
    }
}
