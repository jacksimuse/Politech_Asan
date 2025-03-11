using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace types
{
    class Program
    {
        static void Main(string[] args)
        {
            // 정수형 선언과 예제
            byte age = 25;
            Console.WriteLine("나이 : " + age);

            byte 시계 = 10;
            Console.WriteLine(시계);

            byte 프린터 = 13;
            Console.WriteLine(프린터);

            short temp = 16;
            Console.WriteLine("온도 : " + temp);

            short 휴대폰 = 111;
            Console.WriteLine(휴대폰);

            short 선언; // 선언
            선언 = 10; // 초기화
            Console.WriteLine(선언);

            int number = 100;
            Console.WriteLine("숫자 : " + number);

            int 숫자 = 1234654;
            Console.WriteLine(숫자);

            int 반도체 = 789456123;
            Console.WriteLine(반도체);


            long dis = 123456789;
            Console.WriteLine("거리 : " + dis);

            long 거리 = 1657987498898961951;
            Console.WriteLine(거리);

            uint pos = 4567889;
            Console.WriteLine("양수 : " + pos);

            uint 양수 = 1203715703;
            Console.WriteLine(양수);

            ulong bignumber = 5798949849191918;
            Console.WriteLine("큰수 : " + bignumber);

            //실수형 자료형 예제
            float pi = 3.14f;
            Console.WriteLine("파이 : " + pi);

            double circle = 2.5;
            Console.WriteLine("원 : " + circle);

            decimal monitor = 1.75m;
            Console.WriteLine("모니터 크기 : " + monitor);

            //논리형 자료형 예제
            //불리언(boolean) 참과 거짓을 표현하는 자료형

            bool avocado = true;

            if (avocado)
            {
                Console.WriteLine("우유 6개 사오기");
            }
            else
            {
                Console.WriteLine("빈 손으로 오기");
            }

            bool rain = false;

            if(rain)
            {
                Console.WriteLine("비가 온다");
            }
            else
            {
                Console.WriteLine("비가 안온다");
            }

            // 문자형 자료형 예제
            char a = 'A';
            Console.WriteLine("문자 : " + a);

            Console.WriteLine($"A는 유니코드로 : {(int)a} 입니다. ");

            string hello = "안녕하세요. 수업 2주차입니다.";
            Console.WriteLine("인사 : " + hello);

            int 비번 = 1234;
            string 비밀번호 = Convert.ToString(비번);
            // 1. 숫자를 문자로 변경한다.
            // 2. 바뀐 문자를 Replace를 통해 *로 바꿔준다.
            string 비번변경 = 비밀번호.Replace("1234", "****");
            Console.WriteLine(비번변경);

            string 문장 = hello.Replace("안녕하세요", "잘가세요");   
            Console.WriteLine(문장);

            // char 기능
            // 문자가 10진수 인지 아닌지 확인하는 논리형(bool)
            bool isnum = char.IsDigit(a);
            Console.WriteLine(isnum);

            // string 기능
            // 문자열을 합칠 수 있는 기능
            string plus = "문자를 더할 수 있음";
            string total = hello + plus;
            Console.WriteLine(total);

            // 문자열의 길이를 확인 할 수 있는 기능
            // 반환형 정수(int)
            int 문자열길이 = total.Length;
            Console.WriteLine(문자열길이);

            //strlen -> strlen

            // 문자열의 기능
            // 문자열 자르기 1. 지정 숫자부터 끝까지 2. 지정 숫자부터 지정 길이까지
            string substr = total.Substring(2);
            Console.WriteLine(substr);
            Console.WriteLine(substr.Substring(2, 5));

            // substr = substring


            // object 자료형들의 자료형
            object par = 123;
            object str = "문자열도 담을 수 있음";

            // parents = par

            Console.WriteLine(par);
            Console.WriteLine(str);
        }
    }
}
