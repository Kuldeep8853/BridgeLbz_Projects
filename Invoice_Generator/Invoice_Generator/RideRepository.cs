using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Invoice_Generator
{
    public class RideRepository
    {
       public static Dictionary<Custmor, List<Ride>> RideDictionary = null;
        public RideRepository()
        {
            RideDictionary = new Dictionary<Custmor, List<Ride>>();
        }

        public void AddRide(List<Ride> rides, Custmor custmorId)
        {
            RideDictionary.Add(custmorId, rides);
        }
    }
}
