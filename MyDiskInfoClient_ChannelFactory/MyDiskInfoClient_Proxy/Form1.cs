using MyDiskInfoClient_Proxy.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDiskInfoClient_Proxy
{

    [ServiceContract]
    public interface IMyDiskInfo
    {
        [OperationContract]
        string FreeSpace(string DiskName);
        [OperationContract]
        string TotalSpace(string DiskName);
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyDiskInfoClient proxy = new MyDiskInfoClient();
            string result = proxy.FreeSpace(textBox1.Text);
            textBox2.Text = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyDiskInfoClient proxy = new MyDiskInfoClient();
            string result = proxy.TotalSpace(textBox1.Text);
            textBox2.Text = result;
        }
    }
}
