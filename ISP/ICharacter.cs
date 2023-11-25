using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public interface ICharacter
    {
        void Move();
        void Attack();
        void fly();
    }

    public class Soldier : ICharacter
    {
        public void Move()
        {
            Console.WriteLine("Soldier is Moving ...");
        }

        public void Attack()
        {
            Console.WriteLine("Soldier is attacking ...");
        }

        public void fly()
        {
            throw new NotImplementedException();
        }
    }
    public class Doctor : ICharacter
    {
        public void Move()
        {
            Console.WriteLine("Soldier is Moving ...");
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void fly()
        {
            throw new NotImplementedException();
        }
    } 
    
    public class WarBird : ICharacter
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

}
