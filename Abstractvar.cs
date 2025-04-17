using System;

abstract class SampleBase
{
    // Abstract value
    public abstract int AbstractValue { get; }
}

class Sample2 : SampleBase
{
    static int a = 45, b = 67; // static variables
    int x = 67, y = 89;        // instance variables

    public override int AbstractValue
    {
        get { return x + y; } // Return the sum of x and y
    }

    void Add()
    {
        int p = 34, q = 40; // local variables
        Console.WriteLine(p + q);
    }

  

    static void Main(string[] args)
    {
        Console.WriteLine("hai");
        Sample2 s1 = new Sample2();
        Console.WriteLine(s1.x + s1.y);
        Console.WriteLine(a + b);
        s1.Add();
       
    }
}