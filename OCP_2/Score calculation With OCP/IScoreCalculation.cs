using static System.Formats.Asn1.AsnWriter;

namespace OCP_2.Score_calculation_With_OCP
{
    public interface IScoreCalculation
    {
        double CalculationScore(long amount);
    }
}
