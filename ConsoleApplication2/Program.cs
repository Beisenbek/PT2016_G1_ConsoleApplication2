using System;
using System.Text;

namespace ConsoleApplication2
{
      /// <summary>
      /// 
      /// </summary>
    class Program
    {
        /// <summary>
        /// Считает, является ли число простым
        /// </summary>
        /// <param name="s">входящее число</param>
        /// <returns>истина или ложь</returns>
        static bool IsPrime(string s)
        {
            //превращение из строки в число
            int x = int.Parse(s);

            //предполагаем, что у числа уже два делителя
            int cnt = 2;

            //считаем, сколько еще есть делителей
            for(int i = 2; i <= Math.Sqrt(x); ++i)
            {
                if(x % i == 0)
                {
                    cnt++;
                }
            }

            return (cnt == 2) && (x!= 1);
        }
        /// <summary>
        /// решение через обычный string
        /// </summary>
        static void Solution1(string [] args)
        {
            string s = "";
            // StringBuilder ss;

            for (int i = 0; i < args.Length; ++i)
            {
                string temp = string.Format("{0} is {1}\n", args[i], IsPrime(args[i]));
                s = s + temp;
            }

            Console.WriteLine(s);
        }

        /// <summary>
        /// решение через обычный StringBuilder
        /// </summary>
        static void Solution2(string[] args)
        {
            StringBuilder ss = new StringBuilder();

            for (int i = 0; i < args.Length; ++i)
            {
                ss.AppendFormat("{0} is {1}\n", args[i], IsPrime(args[i]));
            }

            Console.WriteLine(ss.ToString());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Solution2(args);
        }
    }
}
