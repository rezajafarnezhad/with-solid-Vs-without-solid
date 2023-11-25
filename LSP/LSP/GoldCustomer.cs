namespace LSP.LSP;

public class GoldCustomerLSP : CustomerLSP
{
    public override double GetDiscount(double totalSales)
    {
        return totalSales - 100;
    }

    public override void Add()
    {
        Console.WriteLine("Gold Customer Added");
    }
}