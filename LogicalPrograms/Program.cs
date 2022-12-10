namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.PrimeNumber\n2.FibonacciSeries");
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
                }

            }
            
        }
    }
}