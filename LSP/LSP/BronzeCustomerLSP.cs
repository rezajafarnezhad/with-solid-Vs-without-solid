namespace LSP.LSP;

public class BronzeCustomerLSP : CustomerLSP
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