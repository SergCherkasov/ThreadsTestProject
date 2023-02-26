using System.Diagnostics;
using ThreadsTestProject;

Console.WriteLine("***** The Thread App *****");

Console.WriteLine("Do You want [1] or [2] threads?");
string threadCount = Console.ReadLine();

Thread primaryThread = Thread.CurrentThread;
primaryThread.Name = "Primary";

Console.WriteLine("->{0} is executing Main()",
Thread.CurrentThread.Name);

Printer p = new Printer();

switch (threadCount)
{
    case "2":
        Thread backgroundThread = new Thread(new ThreadStart(p.PrintNumbers));
        backgroundThread.Name = "Secondary";
        backgroundThread.Start();
        break;
    case "1":
        p.PrintNumbers();
        break;
    default:
        Console.WriteLine("Error");
        break;
}
Console.WriteLine("This is one of the main thread, and we are finished.");
Console.WriteLine("*");
Console.ReadLine();
Console.WriteLine("1");

