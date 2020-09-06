using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Lib
{
    public static class Reader
    {
        /// <summary>
        /// ReadLine.
        /// </summary>
        /// <returns></returns>
        public static string ReadLine()
        {
            // 文字列の入力
            return Console.ReadLine();
        }

        /// <summary>
        /// Read num.
        /// </summary>
        /// <returns></returns>
        public static long ReadNum()
        {
            return long.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Read string array.s
        /// </summary>
        /// <returns></returns>
        public static string[] ReadStrArray()
        {
            return Console.ReadLine().Split(' ');
        }

        /// <summary>
        /// Read num array.
        /// </summary>
        /// <returns></returns>
        public static long[] ReadNumArray()
        {
            return Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
        }
    }
}