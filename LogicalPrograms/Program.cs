namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.PrimeNumber\n2.FibonacciSeries\n3.PerfectNumber\n4.ReverseNumber\n5.StopWatch\n6.CouponNumbers");
                int option =Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        PrimeNumber prime =new PrimeNumber();
                        prime.Prime();
                        break;
                    case 2:
                        FibonacciSeries series= new FibonacciSeries();
                        series.Fibonacci();
                        break;
                    case 3:
                        PerfectNumber Perfe = new PerfectNumber();
                        Perfe.Perfect();
                        break;
                    case 4:
                        ReverseNumber reverse = new ReverseNumber();
                        reverse.Reverse();  
                        break;
                    case 5:
                        StopWatch stop = new StopWatch();
                        stop.StartSop();
                        break;
                    case 6:
                        CouponNumber coupon = new CouponNumber();
                        coupon.Coupons();
                        break;

       
                }

            }
            
        }
    }
}