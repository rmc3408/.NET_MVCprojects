using System.Collections.Generic;

namespace CarRepair301098080.Models
{
    public static class Repo
    {
        private static List<Car> bundle = new List<Car>();

        public static IEnumerable<Car> Bundle => bundle;

        public static void AddCar(Car theCar)
        {
            bundle.Add(theCar);
        }
    }
}