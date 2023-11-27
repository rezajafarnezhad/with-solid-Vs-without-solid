namespace Static;

public class House
{
    public string Area { get; private set; }
    public int SquareMeters { get; private set; }

    public House(string area, int squareMeters)
    {
        Area = area;
        SquareMeters = squareMeters;
    }

    public double CalculatePrice()
    {
        return SquareMeters * HousePriceCalculator.GetSquareMeterRate(Area);
    }

}