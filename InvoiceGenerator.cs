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
        public double CalculateFare(double Distance, int Time)
        {
            double Fare = (CostPerKm * Distance) + (CostPerMinute * Time);
            return Math.Max(Fare, MinimumFare);
        }
    }
}
