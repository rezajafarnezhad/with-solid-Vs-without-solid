namespace ISP.ISP;

public class WarBirdIPS : ICharacter, IAttack, IFly
{
    public void Move()
    {
        Console.WriteLine("WarBird is Moving ...");
    }

    public void Attack()
    {
        Console.WriteLine("WarBird is Attacking ...");

    }

    public void fly()
    {
        Console.WriteLine("WarBird is flying ...");

    }
}