using System;

class Program
{
    static void Main(string [] args)
    {
        System.Console.WriteLine("Hello world");   
        Console.WriteLine(Fact(0));
    }

    static int Fact(int n)
    {
        if (n == 0)
        return 1;
    }

    static void MyBestMethod()
    {
        Console.WriteLine("Тут была Ксюха!");
    }
}