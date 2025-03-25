using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool 눈 = true;
            bool 비 = false;
            // && 이 기호를 기준으로 앞과 뒤가 둘다 참이거나 거짓일때 참(And)
            Console.WriteLine(눈 && 비);
            // || 이 기호를 기준으로 앞 또는 뒤가 하나만 맞을 때 참 (Or)
            Console.WriteLine(눈 || 비);
            // ! 이 기호를 기준으로 변수의 반대값을 나타냄
            Console.WriteLine(!눈);
            Console.WriteLine(!비);


            // 1. bool 변수 참, 거짓을 만들고 && 를 이용하여 True 라는 값이 나오도록 출력
            // 2. || 를 이용하여 False라는 값이 나오도록 출력
            // 3. !를 이용하여 True 나오게 하기

            bool 참 = true, 거짓 = true;
            //Console.WriteLine(참 && 거짓);
            //참 = 거짓 = false;
            //Console.WriteLine(참 || 거짓);
            //Console.WriteLine(!참);

            //int a = 10, b = 20;
            //Console.WriteLine((a == b) && (a != b)); // False
            //Console.WriteLine((a >= b) || (a <= b)); // True

            //// 1. (a > b) = false, (a < b) = true
            //// 2. false != true  -> true
            //Console.WriteLine((a > b) != (a < b));


            // 1. 숫자 1과 2를 변수에 담고 비교연산자를 사용한다.
            // ==, !=, >, >=, <, <=

            // 2. 비교연산자의 값을 논리 연산자로 비교하여 값을 출력
            // &&, ||, !

            // 3. True, False, False
            int c = 1, d = 2;
            Console.WriteLine((c != d) && (c < d));
            Console.WriteLine((c == d) || (c > d));
            Console.WriteLine(!(c <= d));

        }
    }
}
