using System;
using System.Collections.Generic;
using System.Text;

namespace Invoice_Generator
{
    public class CabInvoiceGenerator
    {
        private const int cost_Per_Minut = 1;
        private const double minimun_Cost_Per_Kilometer = 10;
        private const double minimun_Fare = 5;

        public static double CalculateFare(double kilometer, int time)
        {
            double Total_Cast = kilometer * minimun_Cost_Per_Kilometer + time * cost_Per_Minut;
            return Math.Max(Total_Cast, minimun_Fare);
        }

        public static double CalculateFare(Ride[] rides)
        {
            double Total_fare=0;
            foreach(Ride ride in rides)
            {
                Total_fare+=CalculateFare(ride.Distance, ride.Time);
            }

            return Total_fare;
        }
    }
}
