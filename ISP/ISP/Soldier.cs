namespace ISP.ISP;

public class SoldierIPS : ICharacter,IAttack
{
    public void Move()
    {
        Console.WriteLine("Soldier is Moving ...");
    }

    public void Attack()
    {
        Console.WriteLine("Soldier is attacking ...");
    }
}