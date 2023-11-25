using System.ComponentModel;

namespace LSP
{
    public class Customer
    {
        public int CustomerType { get; set; }

        public virtual double GetDiscount(double totalSales)
        {
            return totalSales;
        }

        public virtual void Add()
        {
            Console.WriteLine("Added");
        }
    }
}
