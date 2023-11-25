using System.Net.NetworkInformation;
using DIP.DAL;
using DIP.Helper;

namespace DIP.BIL;

public class GameBusiness
{
    /// <summary>
    ///  higher-level modules should not depend on lower-level modules; instead, they should both depend on abstractions.
    /// </summary>
    ///public GameDataAccess GameDataAccess = new ();




    private readonly IDataAccess GameDataAccess;
    private readonly ILogger Logger;
    public GameBusiness(IDataAccess dataAccess, ILogger logger)
    {
        GameDataAccess = dataAccess;
        Logger = logger;
    }
    public string PlayGame(long gameId)
    {
        var gameName = GameDataAccess.GetNameBy(gameId);
        Logger.Log($"Logger : {gameName}");
        return $"The Selected Game is :{gameName}";
    }

}