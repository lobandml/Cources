using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cources1
{
    class Program
    {
        static void Main(string[] args)
        {
            string output="|Лобанов Олег Андреевич|";
            StringBuilder sb = new StringBuilder(output.Length);

            sb.Append("+");
            sb.Append('-', output.Length - 2);
            sb.Append("+");

            Console.WriteLine(sb.ToString());
            Console.WriteLine(output);
            Console.WriteLine(sb.ToString());

            Console.ReadKey();
        }
    }
}
