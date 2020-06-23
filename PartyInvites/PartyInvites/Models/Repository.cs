using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public static class Repository
    {
        //data fields also static due to not create objects.
        private static List<GuestResponse> resp = new List<GuestResponse>();

        //static propriety of List of objects
        public static IEnumerable<GuestResponse> Resp
        {
            get { return resp; }
            
        }
        public static void AddResponse(GuestResponse guest)
        {
            resp.Add(guest);
        }
    }
}
