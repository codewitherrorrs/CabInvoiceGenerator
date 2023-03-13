namespace CabinInvoiceGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator!");

            while (true)
            {
                Console.WriteLine("Please choose the option :\n1)Calculate Fare\n2)Aggregate Amount for Multiple Rides");
                int option = Convert.ToInt16(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        InvoiceGenerator uc1 = new();
                        double fare1 = uc1.CalculateFare(10, 30);
                        Console.WriteLine("Total Fare the your Journey is :" + fare1);
                        break;
                    case 2:
                        InvoiceGenerator uc2 = new();
                        MultipleRides[] rides = { new MultipleRides(10, 20), new MultipleRides(15, 25) };
                        double totalfare = uc2.CalculateFare(rides);
                        Console.WriteLine("Aggregate value for Multiple rides is :" + totalfare);
                        break;
                    default:
                        Console.WriteLine("Please choose the correct option!");
                        break;
                }
            }
        }
    }
}