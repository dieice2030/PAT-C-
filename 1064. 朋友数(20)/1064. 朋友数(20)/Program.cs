using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1064.朋友数_20_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, cnt = 1;
            string[] num;
            int[] friendnum;
            string temp;
            temp = Console.ReadLine();
            for(int i=0; i<temp.Length; i++)
            {
                n = n * 10 + (temp[i]-'0');
            }
            List<int> result = new List<int>(n);
            friendnum = new int[n];
            temp = Console.ReadLine();
            num=temp.Split(' ');
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < num[i].Length; j++)
                {
                    friendnum[i] += num[i][j] - '0';
                }
            }
            Array.Sort(friendnum);
            result.Insert(0, friendnum[0]);
            for(int i = 1; i < friendnum.Length; i++)
            {
                if (friendnum[i] != friendnum[i - 1])
                {
                    result.Insert(cnt, friendnum[i]);
                    cnt++;
                }
            }
            Console.WriteLine(result.Count);
            for(int i=0; i < result.Count-1; i++)
            {
                Console.Write("{0} ", result[i]);
            }
            Console.Write(result[result.Count - 1]);
            Console.Read();
            Console.Read();
        }
    }
}
