namespace DIP.DAL;

public class GameDataAccess : IDataAccess
{

    private readonly Dictionary<long, string> GameData = new()
    {
        {1,"Pubg"},
        {2,"Counter-Strike - Global Offensive "},
        {3,"Dota 2"},
        {4,"Fortnite"},
        {5,"god of war"}
    };


    public string GetNameBy(long gameId)
    {
        return GameData[gameId];
    }
}