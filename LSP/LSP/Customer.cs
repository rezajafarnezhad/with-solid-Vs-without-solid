namespace LSP.LSP
{
    public class CustomerLSP : IDiscount, IDataBase
    {
        public int CustomerType { get; set; }

        public virtual double GetDiscount(double totalSales) { return totalSales; }

        public virtual void Add() { Console.WriteLine("Added"); }


        public virtual void Update() { Console.WriteLine("Update"); }
    }
}
