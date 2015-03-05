using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PogodaService
{
    public interface IPogodaManager
    {
        IEnumerable<Pogoda> GetAll();

        void Add(Pogoda item);
    }
}
