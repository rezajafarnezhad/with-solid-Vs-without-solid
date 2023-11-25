using ISP.ISP;

namespace ISP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Soldier s = new Soldier();
            //s.Move();
            //s.Move();
            //s.fly();

            //WarBird w = new WarBird();
            //w.Move();
            //w.Attack();
            //w.fly();


            //Doctor d = new Doctor();
            //d.Attack();
            //d.fly();
            //d.Attack();

            Console.WriteLine("-IPS-");
            SoldierIPS s1 = new SoldierIPS();
            s1.Move();
            s1.Attack();

            WarBirdIPS w1 = new WarBirdIPS();
            w1.Move();
            w1.Attack();
            w1.fly();


            DoctorIPS d1 = new DoctorIPS();
            d1.Move();

            Console.ReadKey();
        }
    }
}
