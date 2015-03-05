using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PogodaService
{
    public class PogodaViewList
    {
        private readonly IPogodaManager _pogodaManager;
        private readonly ILocationManager _locationManager;
        
        List<PogodaList> _items = null;
        List<Pogoda> _pogoda = null;
        List<Location> _location = null;

        static public List<PogodaList> CreatePogodaList(IEnumerable<Pogoda> pogodas, IEnumerable<Location> locations)
        {
            List<PogodaList> PogodaLists =
                new List<PogodaList>();

            var _res =
                from p in pogodas
                join l in locations
                    on p.LocID equals l.LocationID
                select new
                {
                    PogodaID = p.PogodaID,
                    LocationID = l.LocationID,
                    Country = l.country,
                    City = l.city,
                    Temperature = p.temperature,
                    Date = p.Date
                };

            foreach (var r in _res)
            {
                PogodaLists.Add(new PogodaList(r.PogodaID, r.LocationID, r.Country, r.City, r.Temperature, r.Date));
            }

            return PogodaLists;
        }

        public IEnumerable<PogodaList> makeRefresh()
        {
            _items = null;
            _items = CreatePogodaList(_pogodaManager.GetAll(), _locationManager.GetAll());
            return _items;
        }

        public IEnumerable<PogodaList> PogodaList
        {
            get
            {
                if (_items == null)
                {
                    _items = CreatePogodaList(_pogodaManager.GetAll(), _locationManager.GetAll());
                }
                return _items;
            }
        }

        public IEnumerable<Pogoda> Pogodas
        {
            get
            {
                if (_pogoda == null)
                {
                    return _pogodaManager.GetAll();
                }
                return _pogoda;
            }
        }

        public IEnumerable<Location> Locations
        {
            get
            {
                if (_location == null)
                {
                    return _locationManager.GetAll();
                }
                return _location;
            }
        }
        public PogodaViewList(IPogodaManager pogodaManager, ILocationManager locationManager)
        {
            this._pogodaManager = pogodaManager;
            this._locationManager = locationManager;
        }
    }
}
