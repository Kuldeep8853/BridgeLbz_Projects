using System;
using System.Collections.Generic;
using System.Text;

namespace Invoice_Generator
{
    public class Cab_InvoiceGenerator
    {
        private int cost_Per_Minut;
        private double minimun_Cost_Per_Kilometer;
        private double minimun_Fare;
        public Cab_InvoiceGenerator(string Types_Service)
        {
            if (Types_Service.Equals("Premium_Rides"))
            {
                this.cost_Per_Minut = 2;
                this.minimun_Cost_Per_Kilometer = 15;
                this.minimun_Fare = 20;
            }

            if (Types_Service.Equals("Normal_Rides"))
            {
                this.cost_Per_Minut = 1;
                this.minimun_Cost_Per_Kilometer = 10;
                this.minimun_Fare = 5;
            }
        }

        public double CalculateFare(double kilometer, int time)
        {
            double Total_Cast = kilometer * minimun_Cost_Per_Kilometer + time * cost_Per_Minut;
            return Math.Max(Total_Cast, minimun_Fare);
        }

        public double CalculateFare(Ride[] rides)
        {
            double Total_fare = 0;
            foreach (Ride ride in rides)
            {
                Total_fare += CalculateFare(ride.Distance, ride.Time);
            }

            return Total_fare;
        }

        public static int Number_Rides(Ride[] rides)
        {
            return rides.Length;
        }

        public double Avg_Rides(Ride[] rides)
        {
            int length = rides.Length;
            double Total_fare = CalculateFare(rides);
            double Average = Total_fare / length;
            return Average;
        }

        public double GetInvoiceSummary(Custmor User_Id)
        {
            double Total_fare = 0;
            foreach (KeyValuePair<Custmor, List<Ride>> keyvalues in RideRepository.RideDictionary)
            {
                if (User_Id == keyvalues.Key)
                {
                   Total_fare=CalculateFare(keyvalues.Value.ToArray());
                }
            }
            return Total_fare;
        }
    }
}
