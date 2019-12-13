using System;
using System.Threading;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please set up time: ");
            Console.WriteLine("");

            int hours = Convert.ToInt32(Console.ReadLine());
            int minutes = Convert.ToInt32(Console.ReadLine());

            int seconds = 0;

            while(true)
            {

                Console.Clear();
                Console.WriteLine("Current time is: " + hours + " hours " + minutes + " minutes " +
                seconds + " seconds");
                seconds = seconds + 1;
                Thread.Sleep(1000);
                if (hours == 24)
                {
                    hours = 0;
                }
                else if (minutes == 60)
                {
                    minutes = 0;
                    hours = hours + 1;
                }
                else if (seconds == 60)
                {
                    seconds = 0;
                    minutes = minutes + 1;
                }                
              
            }
        }
    }
}
