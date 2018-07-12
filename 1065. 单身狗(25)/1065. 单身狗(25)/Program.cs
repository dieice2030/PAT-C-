using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1065.单身狗_25_
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp;
            int n = 0;
            char[] id;
            int[] IDs;
            temp = Console.ReadLine();
            for(int i = 0; i < temp.Length; i++)
            {
                n = n * 10 + temp[i] - '0';
            }
        }
    }
}
