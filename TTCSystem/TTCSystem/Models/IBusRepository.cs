using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TTCSystem.Models
{
    public interface IBusRepository
    {
        IQueryable<Bus> Buses { get; }

        void SaveBus(Bus bus);

        Bus DeleteBus(int id);
    }
}
