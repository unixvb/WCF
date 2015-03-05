using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PogodaService
{
    [DataContract]
    public class PogodaResult
    {
        [DataMember]
        public string Country;
        [DataMember]
        public string City;
        [DataMember]
        public string Date;
        [DataMember]
        public string Temperature;
    }

    [ServiceContract]
    public interface IMyPogoda
    {
        [OperationContract]
        List<PogodaResult> GetPogodaByCity(string city);
    }
    public class MyPogoda : IMyPogoda
    {
        static public string connectionString =
            ConfigurationManager.ConnectionStrings["PogodaDBEntities"].ConnectionString;
        static public IPogodaManager pogodaManager = new PogodaManager(connectionString);
        static public ILocationManager locationManager = new LocationManager(connectionString);

        static public PogodaViewList pogodaViewList = new PogodaViewList(pogodaManager, locationManager);
        public List<PogodaResult> GetPogodaByCity(string city)
        {
            List<PogodaResult> result = new List<PogodaResult>();
            List<string> strCountry = pogodaViewList.PogodaList.Where(w => w.City == city).OrderBy(c => c.Date).Select(s => s.Country).ToList();
            List<string> strCity = pogodaViewList.PogodaList.Where(w => w.City == city).OrderBy(c => c.Date).Select(s => s.City).ToList();
            List<string> strDate = pogodaViewList.PogodaList.Where(w => w.City == city).OrderBy(c => c.Date).Select(s => s.Date).ToList();
            List<string> strTemperature = pogodaViewList.PogodaList.Where(w => w.City == city).OrderBy(c => c.Date).Select(s => s.Temperature).ToList();
            int count = 0;
            foreach (string str in strCountry)
            {
                result.Add(new PogodaResult() { Country = str, City = strCity[count], Date = strDate[count], Temperature = strTemperature[count] });
                count++; 
            }

            return result;
        }
    }
}
