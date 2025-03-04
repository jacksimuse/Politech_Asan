using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 정수형
            // byte, short, int, long
            byte a = 255; // 0 ~ 255
            Console.WriteLine(a);
            
            short b = 32767; // -32768 ~ 32767         
            Console.WriteLine(b);

            int c = 2147483647; // -2147483648 ~ 2147483647
            Console.WriteLine(c);

            long d = 9223372036854775807; // -9223372036854775808 ~ 9223372036854775807
            Console.WriteLine(d);

            // 실수형
            // float, double, decimal
            float e = 3.14f;
            Console.WriteLine(e);

            double f = 3.14;
            Console.WriteLine(f);

            decimal g = 3.14m;
            Console.WriteLine(g);

            // 문자형
            // char
            char h = 'A';
            Console.WriteLine(h);

            // 문자열
            // string
            string i = "Hello, World!";
            Console.WriteLine(i);

            // 논리형
            // bool
            bool j = true;
            Console.WriteLine(j);

            // object
            object k = null;
            Console.WriteLine(k);

            // var  
            var l = 3.14;
            Console.WriteLine(l);
        }
    }
}
