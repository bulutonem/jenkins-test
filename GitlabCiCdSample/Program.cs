using System;
using System.Timers;

namespace GitlabCiCdSample
{
    class Program
    {
        private static Timer timer = new Timer();
        static void Main(string[] args)
        {
            timer.Elapsed += Timer_Elapsed;
            Console.WriteLine("Hello World!");
            timer.Interval = TimeSpan.FromSeconds(30).TotalMilliseconds;
            timer.Start();
            Console.ReadLine();
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine(DateTime.Now.ToString());
        }
    }
}
