using LSP.LSP;

namespace LSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Customer> customers = new();
            //customers.Add(new GoldCustomer());
            //customers.Add(new SilverCustomer());
            //customers.Add(new BronzeCustomer());

            //foreach (var customer in customers)
            //{
            //    customer.Add();
            //}

            Console.WriteLine("-LSP-");
            List<CustomerLSP> customerLsps = new();
            customerLsps.Add(new GoldCustomerLSP());
            customerLsps.Add(new SilverCustomerLSP());
            customerLsps.Add(new BronzeCustomerLSP());

            foreach (var customer in customerLsps)
            {
                customer.Add();
            }

            List<IDiscount> discounts = new();
            discounts.Add(new GoldCustomerLSP());
            discounts.Add(new SilverCustomerLSP());
            discounts.Add(new BronzeCustomerLSP());
            discounts.Add(new ColleagueLSP());

            foreach (var discount in discounts)
            {
                Console.WriteLine(discount.GetDiscount(3000));
                
            }
            Console.ReadKey();
        }
    }
}
