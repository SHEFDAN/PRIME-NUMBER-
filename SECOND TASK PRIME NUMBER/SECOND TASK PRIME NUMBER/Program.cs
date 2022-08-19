using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SECOND_TASK_PRIME_NUMBER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isprime = true;
            Console.WriteLine("Prime Number");
            for (int i = 2; i <=50; i++)
            {
                for (int j = 2; j <=50; j++)
                {
                    if (i != j && i % j == 0) 
                    {
                        isprime = false;
                        break;


                    }


                }
                if (isprime)
                { 
                     Console.WriteLine("\t" + i);
                }
                    isprime = true;
                
            }

                 Console.ReadKey();

        }
    }
}
