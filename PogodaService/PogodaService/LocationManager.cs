using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PogodaService
{
    public class LocationManager : AbstractManager, ILocationManager
    {
        public LocationManager(string connectionString) : base(connectionString) { }

        public IEnumerable<Location> GetAll()
        {
            using (DbContext ctx = this.CreateDbContext())
            {
                return ctx.Set<Location>().ToList();
            }
        }

        public void Add(Location item)
        {
            using (var ctx = this.CreateDbContext())
            {
                ctx.Set<Location>().Add(item);
                ctx.SaveChanges();
            }
        }
    }
}
