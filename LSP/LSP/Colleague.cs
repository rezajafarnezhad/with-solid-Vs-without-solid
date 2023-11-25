namespace LSP.LSP
{
    public class ColleagueLSP :IDiscount
    {
        public double GetDiscount(double totalSales)
        {
            return totalSales - 5;
        }

    }
}
