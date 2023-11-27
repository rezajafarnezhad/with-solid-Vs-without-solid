namespace HeapStack.@ref.@out.@in;

public class Program
{
    static void Main(string[] args)
    {

        //int number = 100;
        //ChangeNumber(number);
        //Console.WriteLine(number);
        //
        ///
        //int number = 100;
        //ChangeNumber(ref number);
        //Console.WriteLine(number);

        
        int number = 100;
        ChangeNumber(in number);
        Console.WriteLine(number);


        var student = new Student();
        student.Name = "Piter";
        Console.WriteLine(student.Name);
        Console.WriteLine(ChangeName(student));
           



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
    //    num++;
    //    num = 200;
    //    return true;
    //}

    static bool ChangeNumber(in int num) //num is readOnly
    {
        //num++;
        //num = 1000;
        Console.WriteLine(num);
        return true;
    }

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