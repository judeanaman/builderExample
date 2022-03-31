using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace stringbuilderExample
{
    class Program
    {

        static void Main(string[] args)
        {

            // difference in time taken for String and StringBuilder in doing the same number of iterations.
            // start
            string s = "";

            Stopwatch st = new Stopwatch();

            st.Start();

            for (int i = 1; i <= 5000; i++)
            {
                s = s + i;
            }

            //stop
            st.Stop();

            StringBuilder sb = new StringBuilder(5000);

            Stopwatch st1 = new Stopwatch();

            st1.Start();

            for (int i = 1; i <= 5000; i++)
            {
                sb.Append(i);
            }
            st1.Stop();

            Console.WriteLine("Time taken for string: " + st.ElapsedMilliseconds);

            Console.WriteLine("Time taken for StringBuilder: " + st1.ElapsedMilliseconds);

            Console.ReadLine();
        }
    }
}