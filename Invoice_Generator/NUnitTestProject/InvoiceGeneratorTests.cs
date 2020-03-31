using Invoice_Generator;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace NUnitTestProject
{
    public class InvoiceGeneratorTests
    {
        string[] Types_Services = new string[] { "Premium_Rides", "Normal_Rides" };
        [Test]
        public void Test_Ride_Fare1()
        {
            Cab_InvoiceGenerator cab_Invoice = new Cab_InvoiceGenerator(Types_Services[1]);
            double actual = cab_Invoice.CalculateFare(0.1, 2);
            double expected = Math.Max(5, (0.1*10)+(2*1));
            Assert.AreEqual(actual,expected);
        }

        [Test]
        public void Test_Ride_Fare2()
        {
            Cab_InvoiceGenerator cab_Invoice = new Cab_InvoiceGenerator(Types_Services[0]);
            double actual = cab_Invoice.CalculateFare(0.5, 7);
            double expected = Math.Max(5, (0.5 * 15) + (7 * 2));
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Test_MultipleRide_Fare()
        {
            Cab_InvoiceGenerator cab_Invoice = new Cab_InvoiceGenerator(Types_Services[1]);
            Ride[] rides = new Ride[2];
            rides[0] = new Ride { Distance = 2.0, Time = 10 };
            rides[1] = new Ride { Distance = 10.0, Time = 50 };
            double actual = cab_Invoice.CalculateFare(rides);
            double expected = cab_Invoice.CalculateFare(2.0, 10) + cab_Invoice.CalculateFare(10.0, 50);
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Test_Total_Rides()
        {
            Ride[] rides = new Ride[2];
            rides[0] = new Ride { Distance = 0.5, Time = 5 };
            rides[1] = new Ride { Distance = 1.0, Time = 8 };
            double actual = Cab_InvoiceGenerator.Number_Rides(rides);
            double expected = rides.Length;
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Test_Total_Fare()
        {
            Cab_InvoiceGenerator cab_Invoice = new Cab_InvoiceGenerator(Types_Services[0]);
            Ride[] rides = new Ride[2];
            rides[0] = new Ride { Distance = 0.5, Time = 5 };
            rides[1] = new Ride { Distance = 1.0, Time = 8 };
            double actual = cab_Invoice.CalculateFare(rides);
            double expected = cab_Invoice.CalculateFare(0.5, 5) + cab_Invoice.CalculateFare(1.0, 8);
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Test_Avg_Rides()
        {
            Cab_InvoiceGenerator cab_Invoice = new Cab_InvoiceGenerator(Types_Services[0]);
            Ride[] rides = new Ride[2];
            rides[0] = new Ride { Distance = 0.5, Time = 5 };
            rides[1] = new Ride { Distance = 1.0, Time = 8 };
            double actual = cab_Invoice.Avg_Rides(rides);
            double Total_Fare = cab_Invoice.CalculateFare(0.5, 5) + cab_Invoice.CalculateFare(1.0, 8);
            double expected = Total_Fare / rides.Length;
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Given_User_Id_AndGet_Total_Fare_User()
        {
            Cab_InvoiceGenerator cab_Invoice = new Cab_InvoiceGenerator(Types_Services[0]);
            RideRepository rideRepository = new RideRepository();
            List<Ride> rides = new List<Ride>
            {
                new Ride { Distance = 0.5, Time = 5 },
                new Ride { Distance = 1.0, Time = 8 }
            };
            Custmor New_Custmor = new Custmor("Kuldee123");
            rideRepository.AddRide(rides, New_Custmor);
            double actual = cab_Invoice.GetInvoiceSummary(New_Custmor);
            double expected = cab_Invoice.CalculateFare(rides.ToArray());
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Given_User_Id_AndGet_Total_Number_Rides()
        {
            RideRepository rideRepository = new RideRepository();
            List<Ride> rides = new List<Ride>
            {
                new Ride { Distance = 0.5, Time = 5 },
                new Ride { Distance = 1.0, Time = 8 }
            };
            Custmor New_Custmor = new Custmor("Kuldee123");
            rideRepository.AddRide(rides, New_Custmor);
            double actual = InvoiceSummary.GetRides(New_Custmor);
            double expected = Cab_InvoiceGenerator.Number_Rides(rides.ToArray());
            Assert.AreEqual(actual, expected);
        }
    }
}