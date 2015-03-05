using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PogodaService
{
    public class PogodaList
    {
        #region Ctor
        public PogodaList(int PogodaID, int LocationID, string Country, string City, string Temperature, string Date)
        {
            this.PogodaID = PogodaID;
            this.LocationID = LocationID;
            this.Country = Country;
            this.City = City;
            this.Temperature = Temperature;
            this.Date = Date;
        }
        #endregion Ctor

        #region Data Properties
        public int PogodaID { get; set; }
        public int LocationID { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Temperature { get; set; }
        public string Date { get; set; }
        #endregion Data Properties

    }
}
