using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convert
{
    class Program
    {
        static void Main(string[] args)
        {
            // 암시적 형변환
            // int -> long
            int small = 123;
            long big;
            big = small;
            Console.WriteLine(big);

            short 진짜작음 = 1;
            long 진짜큼 = 진짜작음;

            Console.WriteLine(진짜작음);
            Console.WriteLine(진짜큼);

            int 정수 = 123;
            double 실수 = 정수;

            Console.WriteLine(정수);
            Console.WriteLine(실수);


            // int -> double
            double large;
            large = small;
            Console.WriteLine(large);

            // 명시적 형변환  (작은 자료형)큰 자료형 변수
            // double -> int
            double bigbig = 3.14;
            int smallsmall;

            smallsmall = (int)bigbig;
            Console.WriteLine(smallsmall);


            double 소수점 = 1.45;
            int 양수 = (int)소수점;

            Console.WriteLine(양수);
            Console.WriteLine(소수점);

            // Convert를 이용한 형변환 / Convert.을 누르면 다양한 자료형 변환가능
            // string -> int 
            // 구분하는 방법 변환 값에 사칙연산을 해본다.
            string num = "123";
            int pos;
            pos = Convert.ToInt32(num);
            Console.WriteLine(pos);
            Console.WriteLine(num);
            Console.WriteLine(pos + 1);
            Console.WriteLine(num + 1);


            string 인치 = "1.7";
            double 인치변환 = Convert.ToDouble(인치);

            Console.WriteLine(인치);
            Console.WriteLine(인치변환);
            Console.WriteLine(인치 + 1);
            Console.WriteLine(인치변환 + 1);


            // Parse와 TryParse를 이용한 형변환
            // string -> double
            // Parse는 값만 반환한다.
            // TryParse는 변환여부를 반환하며 out으로 값 확인가능

            string pi = "3.14";
            //double pi2 = int.Parse(pi);
            bool trfa;
            trfa = int.TryParse(pi, out int pi3);

            Console.WriteLine(pi + 1);
            //Console.WriteLine(pi2 + 1);
            Console.WriteLine(trfa);
            Console.WriteLine(pi3 + 1);

            // Parse 오류 형태 / 선언한 자료형과 변환하는 자료형이 다를 때 오류가 발생, 프로그램 에러
            // TryParse 오류 형태 / False 값을 반환 오류 발생 없음, 프로그램 에러 없음

            string 참거짓 = "5.5";
            
            bool 소수점확인 = int.TryParse(참거짓, out int 결과값);

            if (소수점확인)
            {
                Console.WriteLine("결과값은 : " + 결과값);
            }
            else
            {
                Console.WriteLine("확인실패");
            }
        }
    }
}
