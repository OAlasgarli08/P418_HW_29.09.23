using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_P418
{
    internal class CustomMath
    {
        public void Array(params int[] n)
        {           
            int sum = 0;
            foreach (int i in n)
            {               
                if(i%2 != 0)
                {
                    sum += i;
                }                
            }
            Console.WriteLine(sum);
        }

        public void OddOrEven(int r)
        {
            if (r%2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }

        public void SquareOfSum(params int[] m)
        {
            int sum = 0;
            foreach (int i in m)
            {
                sum += i;
            }
            Console.WriteLine(sum * sum);
        }

        public void ProductFromOneToP(int p)
        {
            int product = 1;
            for (int i = 1; i <= p; i++)
            {
                product*=i;
            }
            Console.WriteLine(product);
        }
        
    }
}
