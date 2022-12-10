using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class FibonacciSeries
    {
        public void Fibonacci()
          
        {
            Console.WriteLine("enter the number");
            int num=Convert.ToInt32(Console.ReadLine());    
            int firstNumber = 0, secondNumber = 1, thirdNumber;
            Console.WriteLine(firstNumber);
            
            
            for (int i = 1; i < num; i++)
            {
                thirdNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
                Console.WriteLine(thirdNumber);


            }
        }
    }
}
