namespace Static;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(">>>>   Program for Calculating House Price Based on Area and Region Type   <<<<");
        Console.WriteLine("Just enter the desired region code.....");
        Console.WriteLine("Urban Area One => Enter Number : 1 ");
        Console.WriteLine("Urban Area Two => Enter Number : 2 ");
        Console.WriteLine("Urban Area Three => Enter Number : 3 ");
        Console.WriteLine("City Center => Enter Number : 4 ");
        Console.WriteLine("Other Urban Areas => Enter Number : 5 ");
        var area = Console.ReadLine();
        Console.WriteLine("Now, enter the house area in square meters.....");
        var squareMeters = int.Parse(Console.ReadLine());

        var house = new House(area, squareMeters);
        var result = house.CalculatePrice();
        Console.WriteLine($"The approximate price for a house in your selected area is  {result:N0} Tomans.");
    }
}