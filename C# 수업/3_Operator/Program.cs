using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            // == 이 기호를 기준으로 앞과 뒤가 같은지 판단
            //Console.WriteLine(a == b); 
            //// != 이 기호를 기준으로 앞과 뒤가 다른지 판단
            //Console.WriteLine(a != b);
            //// > 이 기호를 기준으로 앞이 뒤보다 큰지 판단
            //Console.WriteLine(a > b);
            //// >= 이 기호를 기준으로 앞이 뒤보다 크고 같은지 판단
            //Console.WriteLine(a >= b);
            //// < 이 기호를 기준으로 앞이 뒤보다 작은지 판단
            //Console.WriteLine(a < b);
            //// <= 이 기호를 기준으로 앞이 뒤보다 작고 같은지 판단
            //Console.WriteLine(a <= b);


            // 숫자 3과 5를 변수에 넣고 비교 연산자를 사용해서 출력
            // ==, !=, >, >=, <, <=
            int c = 3, d = 5;
            // == 이 기호를 기준으로 앞과 뒤가 같은지 판단
            Console.WriteLine(c == d);
            // != 이 기호를 기준으로 앞과 뒤가 다른지 판단
            Console.WriteLine(c != d);
            // > 이 기호를 기준으로 앞이 뒤보다 큰지 판단
            Console.WriteLine(c > d);
            // >= 이 기호를 기준으로 앞이 뒤보다 크고 같은지 판단
            Console.WriteLine(c >= d);
            // < 이 기호를 기준으로 앞이 뒤보다 작은지 판단
            Console.WriteLine(c < d);
            // <= 이 기호를 기준으로 앞이 뒤보다 작고 같은지 판단
            Console.WriteLine(c <= d);

        }
    }
}
