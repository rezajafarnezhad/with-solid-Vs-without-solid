using DIP.BIL;
using DIP.DAL;
using DIP.Helper;

namespace DIP;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-Start Game-");
        GameBusiness gameBusiness = new GameBusiness(new GameDataAccess(),new Logger());
        var playGame = gameBusiness.PlayGame(1);
        Console.WriteLine(playGame);
    }
}