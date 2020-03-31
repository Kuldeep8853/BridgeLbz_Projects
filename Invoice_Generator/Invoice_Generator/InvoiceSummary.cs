using System;
using System.Collections.Generic;
using System.Text;

namespace Invoice_Generator
{
    public class InvoiceSummary
    {
        public int Number_Rides { get; set; }

        public InvoiceSummary(int Number_Rides)
        {
            this.Number_Rides = Number_Rides;
        }

        public static int GetRides(Custmor User_Id)
        {
            foreach (KeyValuePair<Custmor, List<Ride>> keyvalues in RideRepository.RideDictionary)
            {
                if (User_Id == keyvalues.Key)
                {
                    return keyvalues.Value.Count;
                }
            }
            return 0;
        }
    }
}
