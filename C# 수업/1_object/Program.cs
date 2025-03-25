using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_object
{
    class Program
    {
        static void Main(string[] args)
        {
            // object 자료형 예제
            // object > int, string, bool 등등 자료형들을 모두 담을 수 있다.
            // 컴파일 타입 -> 컴파일러(visual studio, 에디터) 가 직접 읽어들여 자료형을 파악

            object obj; // object형 자료형을 만들어 두기 위한 선언
            obj = 999;



            object 아빠 = 1234; // 선언과 동시에 초기화
            Console.WriteLine(아빠);
            Console.WriteLine(아빠.GetType());
            Console.WriteLine();

            아빠 = "문자";
            Console.WriteLine(아빠);
            Console.WriteLine(아빠.GetType());
            Console.WriteLine();

            object 엄마 = "엄마, 아빠 보고싶어";
            Console.WriteLine(엄마);
            Console.WriteLine(엄마.GetType());
            Console.WriteLine();

            // 1. object를 이용하여 변수 친구에 1.23을 넣고 출력,
            // 2 .친구.GetType()을 통해 자료형 출력

            object 친구 = 1.23;
            Console.WriteLine(친구);
            Console.WriteLine(친구.GetType());
            Console.WriteLine();


            // dynamic 자료형 예제
            // dynamic은 프로그램이 작동할 때 자료형이 정해진다.
            // 런타임 타입

            dynamic 할아버지 = 1234;
            Console.WriteLine(할아버지);
            Console.WriteLine(할아버지.GetType());
            Console.WriteLine();

            할아버지 = "문자열";
            Console.WriteLine(할아버지);
            Console.WriteLine(할아버지.GetType());
            Console.WriteLine();

            dynamic 할머니 = "할아버지, 할머니 보고싶어";
            Console.WriteLine(할머니);
            Console.WriteLine(할머니.GetType());
            Console.WriteLine();



            // 1. dynamic을 이용해서 변수 "볼펜"에 'a' 문자 하나 넣고 출력하기
            // 2. 볼펜.GetType() 자료형을 출력해보자
            // 3. 볼펜에  "a"를 다시 대입하고 1.2번을 반복

            dynamic 볼펜 = 'a';
            Console.WriteLine(볼펜);
            Console.WriteLine(볼펜.GetType());
            Console.WriteLine();

            볼펜 = "a";
            Console.WriteLine(볼펜);
            Console.WriteLine(볼펜.GetType());
            Console.WriteLine();


            // var 자료형 예제
            // var는 int, string, bool 등등 모든 자료형을 담을 수 있다.
            // var 한번 초기화 되면 해당 자료형만 써야됨
            // var 컴파일 타입
            // var에는 선언과 동시에 초기화가 되어야 함


            var 형 = 1234;
            Console.WriteLine(형);
            Console.WriteLine(형.GetType());
            Console.WriteLine();

            //형 = "정수형";

            var 누나 = "형, 누나 보고싶어";
            Console.WriteLine(누나);
            Console.WriteLine(누나.GetType());
            Console.WriteLine();

            //누나 = 1234;


            // 1. var를 이용하여 "책상" 변수를 만들고 값은 true를 넣어준다.
            // 2. 책상.GetType()을 해서 자료형을 출력
            // 3, 책상이라는 변수에 0이라는 숫자를 대입해보자

            var 책상 = true;
            Console.WriteLine(책상);
            Console.WriteLine(책상.GetType());
            Console.WriteLine();

            //책상 = 0;

            var 지우개 = 0;

           
        }
    }
}
