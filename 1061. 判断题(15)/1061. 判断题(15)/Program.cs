using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1061.判断题_15_
{
    class Program
    {
        static void Main(string[] args)
        {
            var t=Console.ReadLine();
            var tt = t.Split(' ');
            var nums = Convert.ToInt16(tt[0]);
            var nume = Convert.ToInt16(tt[1]);
            var sco = Console.ReadLine().Split(' ');
            var ans = Console.ReadLine().Split(' ');
            List<string[]> san = new List<string[]>();
            int[] result = new int[nums];
            for(int i = 0; i < nums; i++)
            {
                san.Add(Console.ReadLine().Split(' '));
                for(int j = 0; j < nume; j++)
                {
                    if (san[i][j] == ans[j])
                        result[i] += Convert.ToInt16(sco[j]);
                }
            }
            foreach (var item in result)
                Console.WriteLine(item);

            Console.Read();
            Console.Read();
        }
    }
}
