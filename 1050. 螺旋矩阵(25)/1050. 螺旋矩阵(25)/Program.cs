using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1050.螺旋矩阵_25_
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int m = 0, n, t, i = 0, j = 0, k = 0, dir = 0;
            int[] cnt = new int[4];
            var narray = Console.ReadLine().Split(' ');
            List<int> onarray = new List<int>();
            int[,] result;
            foreach (var item in narray)
            {
                onarray.Add(Convert.ToInt32(item));
            }
            onarray.Sort();
            onarray.Reverse();
            for(int count = 1; count <= Math.Ceiling(Math.Sqrt(num)); count++)
            {
                if(count >= m && num % count == 0)
                    m = count;
            }
            n = num / m;
            if (m < n)
            {
                t = m;
                m = n;
                n = t;
            }
               
            result = new int[m, n];
            while (i < num)
            {
                switch (dir)
                {
                    case 0:
                        for (; k < n - cnt[1]; k++)
                        {
                            result[j, k] = onarray[i];
                            i++;
                        }
                        dir = 1; cnt[0]++; k--;j++;
                        break;
                    case 1:
                        for (; j < m - cnt[2]; j++)
                        {
                            result[j, k] = onarray[i];
                            i++;
                        }
                        dir = 2; cnt[1]++;j--;k--;
                        break;
                    case 2:
                        for (; k >= cnt[3]; k--)
                        {
                            result[j, k] = onarray[i];
                            i++;
                        }
                        dir = 3; cnt[2]++;k++;j--;
                        break;
                    case 3:
                        for (; j >= cnt[0]; j--)
                        {
                            result[j, k] = onarray[i];
                            i++;
                        }
                        dir = 0; cnt[3]++;j++;k++;
                        break;
                }
            }
            for(int x = 0; x < m; x++)
            {
                for(int y = 0; y < n; y++)
                {
                    Console.Write(result[x,y]);
                    if (y != n - 1)
                        Console.Write(" ");
                }
                if(x!=m-1)
                    Console.Write("\n");
            }


            Console.Read();
            Console.Read();
        }
    }
}
