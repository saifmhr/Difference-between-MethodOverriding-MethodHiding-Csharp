using System;


public class BaseClass
{
    public virtual void Print()
    {
        Console.WriteLine("I am base class Print Method");
    }
}

public class DerivedClass:BaseClass
{
    public override void Print()
    {
        Console.WriteLine("I am a Derived class print method");
    }
}

//method hiding
public class BaseClass1
{
    public virtual void Print()
    {
        Console.WriteLine("I am base class1 Print Method");
    }
}

public class DerivedClass1 : BaseClass1
{
    public new void Print()
    {
        Console.WriteLine("I am a Derived class1 print method");
    }
}
public class Program
    {
      public  static void Main()
        {
        BaseClass B = new DerivedClass();
        B.Print();

        BaseClass1 B1 = new DerivedClass1();
        B1.Print();

        }
    }

