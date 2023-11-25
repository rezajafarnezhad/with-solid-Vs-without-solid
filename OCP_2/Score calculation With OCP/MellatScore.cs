﻿namespace OCP_2.Score_calculation_With_OCP;

public class MellatScore : IScoreCalculation
{
    public double CalculationScore(long amount)
    {
        return (5.0 / amount) * 100;
    }
}