using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PatientSystem.Models
{
    public class Repo
    {

        private static IEnumerable<Patient> sicks = new List<Patient>();

        public static IEnumerable<Patient> Sicks 
        {
            get 
            {
                return sicks;
            }
        }




    }
}
