namespace LSP;

public class SilverCustomer : Customer
{
    public override double GetDiscount(double totalSales)
    {
        return totalSales - 50;
    }

    public override void Add()
    {
        Console.WriteLine("Silver Customer Added");
    }
}