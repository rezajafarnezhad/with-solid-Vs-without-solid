namespace LSP.LSP;

public class SilverCustomerLSP : CustomerLSP
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