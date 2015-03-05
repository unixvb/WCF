using PogodaClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PogodaClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    [ServiceContract]
    public interface IMyPogoda
    {
        [OperationContract]
        List<PogodaResult> GetPogodaByCity(string city);
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {
            MyPogodaClient proxy = new MyPogodaClient();
            IAsyncResult asPogoda;
            asPogoda = proxy.BeginGetPogodaByCity(txbFilter.Text, GetPogodaCallback, proxy);
        }

        void GetPogodaCallback(IAsyncResult ar)
        {
            PogodaResult[] result = ((MyPogodaClient)ar.AsyncState).EndGetPogodaByCity(ar);
            string str = "Pogoda: \n";
            foreach (PogodaResult s in result)
            {
                str += "\t" + s.Country + "\t" + s.City + "\t" + s.Date + "\t" + s.Temperature + "\n";
            }
            txbPogoda.Dispatcher.Invoke(delegate()
            {
                txbPogoda.Content = str;
            });
        }
    }
}
