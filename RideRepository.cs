using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinInvoiceGenerator
{
    public class RideRepository
    {
        Dictionary<string, MultipleRides[]> DictionaryOfRideDetails = new Dictionary<string, MultipleRides[]>();
        public RideRepository()
        {
            this.DictionaryOfRideDetails = new Dictionary<string, MultipleRides[]>();
        }
        public void AddRides(string userId, MultipleRides[] rides)
        {
            if (!DictionaryOfRideDetails.ContainsKey(userId))
            {
                DictionaryOfRideDetails.Add(userId, rides);
            }
            else
            {
                Console.WriteLine("Rides are Null");
            }
        }
        public MultipleRides[] GetRide(string userId)
        {
            foreach (var data in DictionaryOfRideDetails)
            {
                if (data.Key == userId)
                {
                    Console.WriteLine("User ID is :" + userId);
                    return data.Value;
                }
                else
                {
                    Console.WriteLine("Invalid User ID");
                }
            }
            return null;
        }
    }
}
