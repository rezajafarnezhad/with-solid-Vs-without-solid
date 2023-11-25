namespace OCP_2.Score_calculation_With_OCP;

public class PasargodScore : IScoreCalculation
{
    public double CalculationScore(long amount)
    {
        return (9.0 / amount) * 100;

    }
}