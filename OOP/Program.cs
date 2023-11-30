using System.Data.Common;
using System.Reflection.PortableExecutable;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            var student = new Student("Ali",3,"Reyazi");

            Console.WriteLine(student.Name);
            Console.WriteLine(student.Age);
            Console.WriteLine(student.Couse);

            student.GetAndShowStudents("Ali","Hamid","Mohammad","Reza");
            var students = new List<string>()
            {
                "Ali", "Hamid", "Mohammad", "Reza"

            };
            student.GetAndShowStudents(students);


            var _c = new Computer("Hp", "2019");
            _c.Year("20200");
            var _m = new Mobile("Asus","2020");
            _m.Application = "insta";
            _m.Year("838483");



            StudentOP studentOp = new StudentOP();
            studentOp.Add();
            studentOp.Update();
            studentOp.Delete();
            studentOp.Get();


            var strudentIntest = new strudentIntest();
          
            ITeacher Iteacher = strudentIntest;
            Iteacher.GetStr();

            IStudent isStudent = strudentIntest;
            isStudent.GetStr();

            AutomobileVehicle authAutomobileVehicle = new AutomobileVehicle();
            authAutomobileVehicle.GetInfo("Benz","280");

            MetroVehicle metroVehicle = new MetroVehicle();
            metroVehicle.GetInfo("Metro Karaj","430");


            AirplaneVehicle airplaneVehicle = new AirplaneVehicle();
            airplaneVehicle.GetInfo("Air Iran","780");

            Gn<string> gn = new Gn<string>();
            gn.Name = "Ali";
            gn.Family = "Mohammadi";
            gn.get("Samal");

            Gn<int> gn2 = new Gn<int>();
            gn2.Name = "hasan";
            gn2.Family = "javadi";
            gn2.get(12);

        }
    }
}


public class Student
{
    public Student(string name, int age, string couse)
    {
        Name = name;
        if (age < 18)
        {
            Age = 18;
        }
        else
        {
            Age = age;
        }
        Couse = couse;
    }

    public string Name { get; set; }

    public int Age { get; set; }
    public string Couse { get; set; }


    public void GetAndShowStudents(params string[] students)
    {
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }

    public void GetAndShowStudents(List<string> students)
    {
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }

}

public abstract class absClass
{
    public string Name { get; set; }
    public abstract void ShowName(string name);
}

public interface IUser
{
    void ShowName(string name);
}

public class test :IUser
{
    public void ShowName(string name)
    {
        throw new NotImplementedException();
    }
}

public class Ob(string name, string family)
{
    public string Name { get; set; } = name;
    public string Family { get; set; } = family;
}




public class Computer
{
    public Computer(string name, string model)
    {
        Name = name;
        Model = model;
    }

    public string Name { get; set; }
    public string Model { get; set; }

    public void Year(string year)
    {
        Console.WriteLine($"Computer {year}");
    }
}


public class Mobile : Computer
{
    public Mobile(string name, string model) : base(name, model)
    {
    }
    public string Application { get; set; }

    public new void Year(string year)
    {
       
        Console.WriteLine($"Mobile {year}");
    }
}


public abstract class DataBase
{
    private readonly string ConnectionString = "DataSurce=.;InitalCatalog =studentDb;";

    public void OpentConnection()
    {
        Console.WriteLine($"Open connection: {ConnectionString}");
    }
    public void CloseConnection()
    {
        Console.WriteLine($"Close connection: {ConnectionString}");
    }


    public abstract void Add();
    public abstract void Update();
    public abstract void Delete();
    public abstract void Get();

}

public interface IStudent
{
    void GetStr();
}
public interface ITeacher
{
   void GetStr();
}

public class strudentIntest: ITeacher,IStudent
{ 
    void ITeacher.GetStr()
    {
        Console.WriteLine("Hi Teacher");
    }

    void IStudent.GetStr()
    {
        Console.WriteLine("Hi Student");
    }


    public void Salam<T>(T Hi)
    {
        Console.WriteLine("Sss");
    }

}



public class StudentOP : DataBase
{

    public override void Add()
    {
        OpentConnection();
        Console.WriteLine("Student Added");
        CloseConnection();
    }

    public override void Update()
    {
        OpentConnection();
        Console.WriteLine("Student Updated");
        CloseConnection();
    }

    public override void Delete()
    {
        OpentConnection();
        Console.WriteLine("Student Deleted");
        CloseConnection();
    }

    public override void Get()
    {
        OpentConnection();
        Console.WriteLine("Student Get");
        CloseConnection();
    }
}




public class Vehicle<T> where T : IVehicle
{
    public virtual void GetInfo(string vehicleName , string speed)
    {
        Console.WriteLine($"Information Name: {vehicleName} Speed : {speed}");
    }
}

public interface IVehicle
{

}

public class AutomobileVehicle : Vehicle<Automobile>
{
  
}

public class MetroVehicle : Vehicle<Metro>
{

}

public class AirplaneVehicle : Vehicle<Airplane>
{

}
public class Automobile : IVehicle
{
    public string Name { get; set; }
    public string Speed { get; set; }
}

public class Metro : IVehicle
{
    public string Name { get; set; }
    public string Speed { get; set; }

}

public class Airplane : IVehicle
{
    public string Name { get; set; }
    public string Speed { get; set; }
}



public class Gn<T>
{
    public string Name { get; set; }
    public string Family { get; set; }

    public void get(T value)
    {
        Console.WriteLine(value.ToString());
    }
}


