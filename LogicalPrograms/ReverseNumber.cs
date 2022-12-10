using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        public void Reverse()
        {
            Console.WriteLine("Enter a number ");
            int number = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;
            while (number != 0)
            {
                int reminder = number % 10;
                reverse =reverse *  10 + reminder;
                number = number/ 10; 
            }
            Console.WriteLine("Reverse of given number =" + reverse);
        }
    }
}