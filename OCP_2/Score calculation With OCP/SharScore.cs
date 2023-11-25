namespace OCP_2.Score_calculation_With_OCP;

public class SharScore : IScoreCalculation
{
    public double CalculationScore(long amount)
    {
        return (8.5 / amount) * 100;
    }
}