using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1051.复数乘法__15_
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            double[] num = new double[4];
            for(int i = 0; i < 4; i++)
            {
                num[i] = Convert.ToDouble(input[i]);
            }
            var a = num[0] * Math.Cos(num[1]) * num[2] * Math.Cos(num[3]) - num[0] * Math.Sin(num[1]) * num[2] * Math.Sin(num[3]);
            var b = num[0] * Math.Cos(num[1]) * num[2] * Math.Sin(num[3]) + num[2] * Math.Cos(num[3]) * num[0] * Math.Sin(num[1]);
            if(b>=0)
                Console.Write(Math.Round(a, 2) + "+" + Math.Round(b, 2) + "i");
            else
                Console.Write(Math.Round(a, 2) + "-" + -Math.Round(b, 2) + "i");

            Console.Read();
            Console.Read();
        }
    }
}
