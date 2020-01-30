using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATH3307_CounterExampleGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int k = 1; k < 1E6; k++)
            {

                long b = (long)k * k * k;
                if (b > 1E9)
                    break;
                Console.WriteLine("k = {0}", k);
                for(int c = 0; c < 1E9; c++)
                {
                    if (c % k == 0)
                        continue;
                    long a = (long)k * k * c;
                    if (a > 1E9)
                        break;
                    if (a % b == 0)
                    {
                        Console.WriteLine("Counter Example: {0}, {1}", a, b);
                    }
                }
            }
            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}
