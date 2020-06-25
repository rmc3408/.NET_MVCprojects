using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportStore.Models
{
    public class EFRepository : IProductRepository
    {
        private DataB context;

        public EFRepository(DataB ctx)
        {
            context = ctx;
        }

        public 


    }
}
