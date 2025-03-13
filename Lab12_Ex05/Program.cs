using System;

class BaseClass1
{
    public void ShowBase1()
    {
        Console.WriteLine("This is BaseClass1");
    }
}

class BaseClass2
{
    public void ShowBase2()
    {
        Console.WriteLine("This is BaseClass2");
    }
}

class DerivedClass
{
    private BaseClass1 base1 = new BaseClass1();
    private BaseClass2 base2 = new BaseClass2();

    public void Show()
    {
        base1.ShowBase1();
        base2.ShowBase2();
        Console.WriteLine("This is DerivedClass");
    }
}

class Program
{
    static void Main()
    {
        DerivedClass dc = new DerivedClass();
        dc.Show();
    }
}
