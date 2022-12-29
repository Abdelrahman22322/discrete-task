using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discrete_1
{
    internal class Program
    {
        static void Main(string[] args)


        {

            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = start; i<=end; i++)
            {
                for (int x = 1; x<=i; x++)
                {
                    if (i%x==0)
                        sum++;
                }
                if (sum==2)
                {
                    Console.WriteLine(i);
                    sum=0;
                }
                else
                {
                    sum=0;
                    continue;
                }
            }


        }
    }
}
