using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PatientSystem.Models
{
    public static class Repo
    {

        private static List<Patient> sicks = new List<Patient>();

        public static IEnumerable<Patient> Sicks 
        {
            get 
            {
                return sicks;
            }
        }
        public static void AddPatToRep(Patient thesick)
        {
            sicks.Add(thesick);

        }

           

    }
}
