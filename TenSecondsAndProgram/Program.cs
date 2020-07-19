using System;

namespace TenSecondsAndProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program is treminated after 10 seconds");
            Console.WriteLine(" ");

            var myStartTime = DateTime.Now;
            var temp = myStartTime;
            DateTime myCurrentTime;
            try
            {
                for (long i = 0; i < long.MaxValue; i++)
                {
                    // Console.WriteLine(i);
                    myCurrentTime = DateTime.Now;
                    if (Math.Abs((myCurrentTime - myStartTime).TotalSeconds) >= 10)
                        throw new TimeoutException();
                }
            }
            catch (TimeoutException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("--- Your time is expired ---");
                Console.WriteLine(" ");
            }
            finally
            {
                Console.WriteLine("Hello again!!!!!!!!");
                Console.WriteLine($"Start time: {temp.TimeOfDay}");
                Console.WriteLine($"Start time: {DateTime.Now.TimeOfDay}");
            }
        }
    }
}
