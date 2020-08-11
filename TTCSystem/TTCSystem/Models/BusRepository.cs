using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TTCSystem.Models
{
    public class BusRepository : IBusRepository
    {
        private AppDbContext context;

        public BusRepository(AppDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Bus> Buses => context.Buses;

        public void SaveBus(Bus bus)
        {
            if (bus.BusNumber == 0)
            {
                context.Buses.Add(bus);
            }
            else
            {
                Bus busEntry = context.Buses
                    .FirstOrDefault(b => b.BusNumber == bus.BusNumber);

                if (busEntry != null)
                {
                    busEntry.RouteName = bus.RouteName;
                    busEntry.PlateNumber = bus.PlateNumber;
                    busEntry.InOperation = bus.InOperation;
                }
            }

            context.SaveChanges();
        }

        public Bus DeleteBus(int id)
        {
            Bus busEntry = context.Buses
                .FirstOrDefault(p => p.BusNumber == id);

            if (busEntry != null)
            {
                context.Buses.Remove(busEntry);
            }

            return busEntry;
        }


    }
}
