using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class StopWatch
    {
        public void StartSop()
        {
            Stopwatch stopwatch = new Stopwatch();
           
            Console.WriteLine("Press any key to start stopwatch");
            Console.ResetColor();
            Console.ReadKey();
            stopwatch.Start();

            Console.WriteLine("Press any key to stop stopwatch");
            Console.ResetColor();
            Console.ReadKey();
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}:{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine(elapsedTime);


        }
       
        
    }
}
