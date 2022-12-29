using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discrete_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter frist num");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second num ");
            int end = int.Parse(Console.ReadLine());
            int sum = 0;
            for( int x = start; x <= end; x++)
            {

                sum = 0;
                for(int i = 1; i <= x; i++)
                {

                    if(x % i ==0)
                    {
                        sum += i;
                    }

                    if(sum == x)
                    {

                        Console.WriteLine(x+"is a perfect mumber");
                    }             
                }
            }

        }
    }
}
