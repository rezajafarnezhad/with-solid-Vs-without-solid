using System.Linq.Expressions;

namespace LSP
{
    public class Colleague :Customer
    {
        public override double GetDiscount(double totalSales)
        {
            return totalSales - 5;
        }

        public override void Add()
        {
            throw new  Exception("Not ... ");
        }
    }
}
