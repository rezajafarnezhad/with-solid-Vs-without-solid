using OCP_2.Profit_calculation_Without_OCP;
using OCP_2.Score_calculation_With_OCP;

namespace OCP_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-Profit calculation Without OCP-");
            Console.WriteLine(ScoreCalculation.Calculation(340,PaymentGateway.Meli));
            Console.WriteLine(ScoreCalculation.Calculation(340,PaymentGateway.Mellat));
            Console.WriteLine(ScoreCalculation.Calculation(340,PaymentGateway.Shahr));

            Console.WriteLine("-Profit calculation With OCP-");

            var melliScore = new MeliScore();
            Console.WriteLine(melliScore.CalculationScore(340));

            var mellatScore = new MellatScore();
            Console.WriteLine(mellatScore.CalculationScore(340));

            var sharScore = new SharScore();
            Console.WriteLine(sharScore.CalculationScore(340));

            var pasargod = new PasargodScore();
            Console.WriteLine(pasargod.CalculationScore(340));

            Console.ReadKey();
        }
    }
}
