using System;

namespace Test_CSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //  DateTime

            //----------------------------------------------------------
            
            //  Testing is the year a leap-year?
            var isLeapYear = DateTime.IsLeapYear(2015);
            Console.WriteLine(isLeapYear);

            // Today but not the exact time. To get exact exact time we use DateTime.Now 
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Today.Year);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
            Console.WriteLine(DateTime.Now.Millisecond);

            Console.WriteLine(isLeapYear);

            Console.WriteLine(DateTime.Now.Ticks);
            Console.WriteLine(DateTime.MaxValue);
            Console.WriteLine(DateTime.UtcNow);
            Console.WriteLine(DateTime.MinValue);
            Console.WriteLine(DateTime.Compare(new DateTime(2020, 6, 10), new DateTime(2021, 12, 1, 12, 30, 30)));
            Console.WriteLine(DateTime.DaysInMonth(2022, 2));
            Console.WriteLine(DateTime.Now.AddDays(5000));

            /*Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            long a = 10;
            Console.WriteLine(a);

            Console.Beep(32767, 1000);
            Console.Beep(100, 1000);
            Console.Beep(1000, 1000);
            Console.Beep(5000, 1000);
            Console.Beep(50, 1000);

            Console.Clear();*/

            // shortcut : uncomment - ctrl + k + u, comment - ctrl + k + c
            /*Console.Write("Bangladesh" + Environment.NewLine + " is a beautiful country");*/

            //ConsoleColor consoleColor = ConsoleColor.Green;
            //Console.WriteLine(consoleColor);

            /*Console.Beep(100, 3000);

            Console.ResetColor();
            Console.Clear();

            string message = Console.ReadLine();
            Console.Write("you are " + message);*/
            

            Console.ReadLine();
        }
    }
}
