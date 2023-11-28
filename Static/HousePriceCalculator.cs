namespace Static;
public static class HousePriceCalculator
{
    private static double Urban_Area_One = 50_000_000;
    private static double Urban_Area_Two = 40_000_000;
    private static double Urban_Area_Three = 35_000_000;
    private static double City_Center = 70_000_000;
    private static double Other_Urban_Areas = 25_000_000;
    public static double GetSquareMeterRate(string area)
    {
        switch (area)
        {
            case "1": return Urban_Area_One;
            case "2": return Urban_Area_Two;
            case "3": return Urban_Area_Three;
            case "4": return City_Center;
            default: return Other_Urban_Areas;
        }
    }
}