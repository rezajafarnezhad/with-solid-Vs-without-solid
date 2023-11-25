namespace LSP;

public class BronzeCustomer : Customer
{
    public override double GetDiscount(double totalSales)
    {
        return totalSales - 25;
    }

    public override void Add()
    {
        Console.WriteLine("Bronze Customer Added");
    }
}