using System;
using System.Collections.Generic;

namespace Invoice_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RideRepository rideRepository = new RideRepository();
            List<Ride> rides = new List<Ride>
            {
                new Ride { Distance = 0.5, Time = 5 },
                new Ride { Distance = 1.0, Time = 8 }
            };
            Custmor New_Custmor = new Custmor("Kuldee123");
            rideRepository.AddRide(rides, New_Custmor);
            List<Ride> rides1 = new List<Ride>
            {
                new Ride { Distance = 0.5, Time = 5 },
                new Ride { Distance = 10.0, Time = 30 }
            };
            Custmor New_Custmor1 = new Custmor("Ajskfhs123");
            rideRepository.AddRide(rides1, New_Custmor1);
            Cab_InvoiceGenerator.GetInvoiceSummary(New_Custmor);
        }
    }
}
