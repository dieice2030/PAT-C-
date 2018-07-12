using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1049.数列的片段和_20_
{
    class Program
    {
        static void Main(string[] args)
        {
            var num=  Convert.ToInt32(Console.ReadLine());
            var narray = Console.ReadLine().Split(' ');
            double[] c = new double[num];
            double sum = 0;
            string result;
            int i = 0;
            foreach(var item in narray)
            {
                c[i] = Convert.ToDouble(item);
                i++;
            }
            for(int cnt = 0; cnt < num; cnt++)
            {
                sum += c[cnt] * cnt * (c.Length - cnt)  + c[cnt] * (c.Length - cnt);
            }
            result = string.Format("{0:F}", Math.Round(sum,2));
            Console.Write(result);

            Console.Read();
            Console.Read();
        }
    }
}
