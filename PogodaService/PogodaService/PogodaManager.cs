using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PogodaService
{
    public class PogodaManager : AbstractManager, IPogodaManager
    {
        public PogodaManager(string connectionString) : base(connectionString) { }

        public IEnumerable<Pogoda> GetAll()
        {
            using (DbContext ctx = this.CreateDbContext())
            {
                return ctx.Set<Pogoda>().ToList();
            }
        }

        public void Add(Pogoda item)
        {
            using (var ctx = this.CreateDbContext())
            {
                ctx.Set<Pogoda>().Add(item);
                ctx.SaveChanges();
            }
        }
    }
}
