using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1048.数字加密_20_
{
    class Program
    {
        static char Change(int ch)
        {
            char result;
            if (ch < 9 && ch >= 0)
                result = Convert.ToChar(ch);
            else if (ch == 9)
                result = '9';
            else if (ch == 10)
                result = 'J';
            else if (ch == 11)
                result = 'Q';
            else if (ch == 12)
                result = 'K';
            else
                result = 'X';
            return result;
        }
        static void ShowResult(char ch)
        {
            if (Convert.ToByte(ch) < 9)
                Console.Write(Convert.ToByte(ch));
            else
                Console.Write(ch);
        }
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var temp=input.Split(' ');
            var a = temp[0];
            var b = temp[1];
            Stack<char> x = new Stack<char>();
            Stack<char> y = new Stack<char>();
            Stack<char> result = new Stack<char>();
            var lenx = a.Length;
            var leny = b.Length;
            int m, n;
            if (lenx > leny)
            {
                for(int i =0;i<lenx-leny;i++)
                {
                    y.Push('0');
                }
            }
            else
            {
                for(int i = 0; i < leny - lenx; i++)
                {
                    x.Push('0');
                }
            }
            foreach (var item in a)
            {
                x.Push(item);
            }
            foreach(var item in b)
            {
                y.Push(item);
            }
            var len = x.Count();
            for(int i = 0; i < len; i++)
            {
                m = x.Pop() - '0';
                n = y.Pop() - '0';
                int t;
                if (i % 2 == 0)
                {
                    t = (m + n) % 13;
                    var tt=Change(t);
                    result.Push(Change(t));
                }
                else
                {
                    t = n - m;
                    if (t < 0)
                        t += 10;
                    result.Push(Change(t));
                }
            }
            for(int i = 0; i < len; i++)
            {
                ShowResult(result.Pop());
            }






            Console.Read();
            Console.Read();
        }
    }
}
