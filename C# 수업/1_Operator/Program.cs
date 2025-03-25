using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            Console.WriteLine(a + b); // 15
            Console.WriteLine(a - b); // 5
            Console.WriteLine(a * b); // 50
            Console.WriteLine(a / b); // 2
            Console.WriteLine(a % b); // 0

            // int c,d에 각각 20과 10을 넣고 5가지 연산을 해봅시다. 출력까지
            int c = 20, d = 10;
            Console.WriteLine(c + d); // 15
            Console.WriteLine(c - d); // 5
            Console.WriteLine(c * d); // 50
            Console.WriteLine(c / d); // 2
            Console.WriteLine(c % d); // 0

        }
    }
}
