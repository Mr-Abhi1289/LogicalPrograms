using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class CouponNumber
    {
        public void Coupons()
        {

            Console.WriteLine("Number of coupons to create... ? ");
            int num = int.Parse(Console.ReadLine());
            Random random = new Random();
            int[] arr = new int[num];
            for (int i = 0; i < arr.Length; i++)
            {

                int randomNum = random.Next(0, 1000000);
                arr[i] = randomNum;
            }
            foreach (var data in arr)
            {
                if (data != 0)
                {
                    Console.WriteLine(data);
                }
            }
        }
    }
}

