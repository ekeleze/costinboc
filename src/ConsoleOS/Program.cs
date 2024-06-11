using MOOS;
using System;
using System.Runtime;

unsafe class Program
{
    static void Main() { }

    [RuntimeExport("KMain")]
    static void KMain() 
    {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(@" ________  ________  ________  _________  ___  ________   ________  ________  ________");
        Console.WriteLine(@"|\   ____\|\   __  \|\   ____\|\___   ___\\  \|\   ___  \|\   __  \|\   __  \|\   ____\");
        Console.WriteLine(@"\ \  \___|\ \  \|\  \ \  \___|\|___ \  \_\ \  \ \  \\ \  \ \  \|\ /\ \  \|\  \ \  \___|");
        Console.WriteLine(@" \ \  \    \ \  \\\  \ \_____  \   \ \  \ \ \  \ \  \\ \  \ \   __  \ \  \\\  \ \  \");
        Console.WriteLine(@"  \ \  \____\ \  \\\  \|____|\  \   \ \  \ \ \  \ \  \\ \  \ \  \|\  \ \  \\\  \ \  \");
        Console.WriteLine(@"   \ \_______\ \_______\____\_\  \   \ \__\ \ \__\ \__\\ \__\ \_______\ \_______\ \_______\");
        Console.WriteLine(@"    \|_______|\|_______|\_________\   \|__|  \|__|\|__| \|__|\|_______|\|_______|\|_______|");
        Console.WriteLine(@"                       \|_________|");

        for(; ; ) 
        {
            string s = Console.ReadLine();
            Console.WriteLine(s);
        }
    }
}