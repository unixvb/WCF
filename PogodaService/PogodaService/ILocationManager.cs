using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PogodaService
{
    public interface ILocationManager
    {
        IEnumerable<Location> GetAll();

        void Add(Location item);
    }
}
