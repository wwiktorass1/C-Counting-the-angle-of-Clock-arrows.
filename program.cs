using System;
using System.IO;

namespace CountingTheAngleOfClockArrows
{
    class Program
    {

        static int hour;
        static int minute;

        static void Main(string[] args)
        {
            while (true)
            {
                inputHour();
                inputMinute();
                Console.WriteLine("-----------------------");
                Console.WriteLine("hour: " + hour + ", minute: " + minute);
                calculateAngle();
                Console.WriteLine("-----------------------");

                Main(args);
            }
        }

        private static void calculateAngle()
        {
            int angle = Math.Abs((360 * minute / 60) - (360 * hour / 12)); //- (30*minute/60)));
            if (angle <= 180)
            {

                Console.WriteLine("Angle is: " + Math.Abs(angle));
            }
            else if (angle > 180)
            {
                angle = 360 - angle;
                Console.WriteLine("Angle is: " + Math.Abs(angle));
            }
        }

        private static int inputMinute()
        {
            do
            {
                Console.WriteLine("Enter minute value:");
                try
                {
                    minute = int.Parse(Console.ReadLine());
                    if (minute < 0)
                    {
                        Console.WriteLine("Invalid input, number of minutes must be positive");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("No numbers entered! \n");
                }
   
            } while (minute < 0);
            if (minute <= 60)
            {
                return minute;
            }
            else
            {
                Console.WriteLine("Big minute input.");
                inputMinute();
            }
            return minute;
        }

        private static int inputHour()
        {
            bool loop = true;
            do
            {
                Console.WriteLine("Enter hour value:");
                try
                {
                    hour = int.Parse(Console.ReadLine());
                    if (hour < 0)
                    {
                        Console.WriteLine("Invalid input, number of hours must be positive");
                        inputHour();
                    }
                    loop = false;
                }
                catch (FormatException )
                {
                    Console.WriteLine("No numbers entered! \n");

                }
            } while (loop);

            if (hour < 12)
            {
                return hour;
            }
            else if (hour >= 12 && hour <= 24)
            {
                hour = Math.Abs(12 - hour);

            }
            else
            {
                Console.WriteLine("Big hour input.");
                inputHour();
            }
            return hour;
        }
    }

}


