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
        public double CalculateFare(MultipleRides[] ride)
        {
            double totalfare = 0;
            foreach (MultipleRides rides in ride)
            {
                totalfare = totalfare + CalculateFare(rides.Distance, rides.Time);
            }
            return totalfare;
        }
    }
}
