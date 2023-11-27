namespace HeapStack.@ref.@out.@in;

public class Program
{
    static void Main(string[] args)
    {

        //int number = 100;
        //ChangeNumber(number);
        //Console.WriteLine(number);



        //Ref

        //int number = 100;
        //ChangeNumber(ref number);
        //Console.WriteLine(number);


        //out writeOnly 

        //int number = 100; 
        //ChangeNumber(out number);
        //Console.WriteLine(number);


        //in readOnly

        //int number = 100;
        //ChangeNumber(in number);
        //Console.WriteLine(number);


        var student = new Student();
        student.Name = "Piter";
        Console.WriteLine(student.Name);
        Console.WriteLine(ChangeName(student));

        Console.WriteLine("Please enter seconds....");
        var second = int.Parse(Console.ReadLine());
        ConvertSecondToHour(ref second);
        Console.WriteLine($"Equal to {second}  hours");

        int minutes = 90;
        ConvertMinutesToSeconds(out minutes);
        Console.WriteLine($"90 minutes is equal to {minutes} seconds");

        Console.WriteLine();
    }

    static void ConvertSecondToHour(ref int second)
    {
        second /= 3600;
    }

    static void ConvertMinutesToSeconds(out int minutes)
    {
        minutes = 5400;
    }

    //static bool ChangeNumber(int num)
    //{
    //    num++;
    //    return true;
    //}


    //static bool ChangeNumber(ref int num)
    //{
    //    num++;
    //    return true;
    //}

    //static bool ChangeNumber(out int num)
    //{
    //   // num++; //invalid
    //    num = 200;
    //    return true;
    //}

    //static bool ChangeNumber(in int num) //num is readOnly
    //{
    //    //num++;//invalid
    //    //num = 1000;//invalid
    //    Console.WriteLine(num);
    //    return true;
    //}

    static string ChangeName(Student st)
    {
        return st.Name = "jak";
    }

}


public class Student
{
    public string Name { get; set; }
    public string Family { get; set; }

}