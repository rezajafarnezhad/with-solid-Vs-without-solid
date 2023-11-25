namespace OCP_2.Score_calculation_With_OCP;

public class MeliScore : IScoreCalculation
{
    public double CalculationScore(long amount)
    {
        return (7.0 / amount) * 100;
    }
}