using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoder.Abc
{
    //https://atcoder.jp/contests/abc141/tasks/abc141_a
    public class QuestionA
    {
        public static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            var a = Common.ReadNum();
            var b = Common.ReadNumArray();
            var s = Common.ReadLine();

            Common.WriteResult($"{a + b[0] + b[1]} {s}");

            Console.Out.Flush();
        }

        public static class Common
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

            /// <summary>
            /// Write result.
            /// </summary>
            /// <param name="result">result.</param>
            public static void WriteResult(string result)
            {
                Console.WriteLine(result);
            }
        }
    }
}
