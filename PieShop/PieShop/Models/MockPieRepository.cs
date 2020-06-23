using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private List<Pie> _pies;

        public MockPieRepository()
        {
            if (_pies == null)
            {
                InitPies();
            }
        }
        private void InitPies()
        {
            _pies = new List<Pie>
            {
                new Pie {Id=1,Name="cherry pie", price=12.95, IsPieOfWeek= true},
                new Pie {Id=2,Name="banana pie", price=16.95, IsPieOfWeek= false}

            };
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _pies;
        }

        public Pie GetPiebyId(int pieId)
        {
            return _pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
