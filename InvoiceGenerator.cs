using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinInvoiceGenerator
{
    public class InvoiceGenerator
    {

        public double CostPerKm = 10;
        public int CostPerMinute = 1;
        public int MinimumFare = 5;
        public int count;

        public double CalculateFare(double Distance, int Time)
        {

            count++;
            double Fare = (CostPerKm * Distance) + (CostPerMinute * Time);
            return Math.Max(Fare, MinimumFare);
        }
        public double CalculateFare(MultipleRides[] ride, string RideType)
        {
            if (RideType == "Normal")
            {
                CostPerKm = 10;
                CostPerMinute = 1;
                MinimumFare = 5;
            }
            else if (RideType == "Premium")
            {
                CostPerKm = 15;
                CostPerMinute = 2;
                MinimumFare = 20;
            }
            double totalfare = 0;
            foreach (MultipleRides rides in ride)
            {
                totalfare = totalfare + CalculateFare(rides.Distance, rides.Time);

            }
            return totalfare;
        }
        public void InvoiceSummary(MultipleRides[] ride, string RideType)
        {

            foreach (MultipleRides rides in ride)
            {
                Console.WriteLine("Ride Type :" + RideType);
                Console.WriteLine("Distance Travelled :" + rides.Distance);
                Console.WriteLine("Time Taken :" + rides.Time);
                Console.WriteLine("Fare for ride is :" + CalculateFare(rides.Distance, rides.Time));
            }
        }
    }
}
