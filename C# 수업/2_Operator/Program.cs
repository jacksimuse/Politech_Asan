using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10; // 10
            a = a + 1; // 11
            a += 1; // a = a + 1; -> 12
            a -= 1; // a = a - 1; -> 11
            a *= 2; // a = a * 2; -> 22
            a /= 2; // a = a / 2; -> 11
            a %= 2; // a = a % 2; -> 1

            //Console.WriteLine(a); 

            // 숫자 5를 가지고 1,2,3,4,5를 할당해주세요 * 각 기호 전부 사용
            int b = 5;
            b += 1;
            b -= 2;
            b *= 3;
            b /= 4;
            b %= 5;

            Console.WriteLine(b);
        }
    }
}
