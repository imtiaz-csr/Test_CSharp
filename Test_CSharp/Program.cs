using System;

namespace Test_CSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            long a = 10;
            Console.WriteLine(a);

            Console.Beep(32767, 1000);
            Console.Beep(100, 1000);
            Console.Beep(1000, 1000);
            Console.Beep(5000, 1000);
            Console.Beep(50, 1000);

            Console.Clear();

            // shortcut : uncomment - ctrl + k + u, comment - ctrl + k + c
            Console.Write("Bangladesh" + Environment.NewLine + " is a beautiful country");

            //ConsoleColor consoleColor = ConsoleColor.Green;
            //Console.WriteLine(consoleColor);

            Console.Beep(100, 3000);

            Console.ResetColor();
            Console.Clear();

            string message = Console.ReadLine();
            Console.Write("you are " + message);
            

            Console.ReadLine();
        }
    }
}
