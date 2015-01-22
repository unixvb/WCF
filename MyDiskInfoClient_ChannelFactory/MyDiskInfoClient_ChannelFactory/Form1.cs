using MyDiskInfoClient_ChannelFactory.ServiceReference1;
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

namespace MyDiskInfoClient_ChannelFactory
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
            ChannelFactory<IMyDiskInfo> factory = new ChannelFactory<IMyDiskInfo>(new BasicHttpBinding(), new EndpointAddress("http://localhost/MyDiskInfo/EP1"));
            IMyDiskInfo channel = factory.CreateChannel();
            string result = channel.FreeSpace(textBox1.Text);
            textBox2.Text = result;
            factory.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChannelFactory<IMyDiskInfo> factory = new ChannelFactory<IMyDiskInfo>(new BasicHttpBinding(), new EndpointAddress("http://localhost/MyDiskInfo/EP1"));
            IMyDiskInfo channel = factory.CreateChannel();
            string result = channel.TotalSpace(textBox1.Text);
            textBox2.Text = result;
            factory.Close();
        }
    }
}
