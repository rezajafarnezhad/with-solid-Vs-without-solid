namespace OCP_2.Profit_calculation_Without_OCP
{
    public class ScoreCalculation
    {
        public static double Calculation(long amount, PaymentGateway paymentGateway)
        {
            double Score = 0;

            if (paymentGateway == PaymentGateway.Mellat)
            {
                Score = (5.0/amount)*100;
            }
            else if (paymentGateway == PaymentGateway.Meli)
            {
                Score = (7.0/amount) * 100;

            }
            else if (paymentGateway == PaymentGateway.Shahr)
            {
                Score = (8.5 /amount) * 100;

            }
            return Score;
        }
    }
}
