using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinInvoiceGenerator
{
    public class MultipleRides
    {
        public double Distance;
        public int Time;
        public MultipleRides(double Distance, int Time)
        {
            this.Time = Time;
            this.Distance = Distance;
        }
    }
}
