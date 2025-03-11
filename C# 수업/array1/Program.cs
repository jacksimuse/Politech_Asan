using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 정수형 배열 자료형 선언 / 오른쪽 대괄호[] 안에 숫자만큼 공간이 생김 / 자동 초기화 0
            int[] number = new int[6];

            double[] 소수점배열 = new double[5];
            
            소수점배열[0] = 1.25;
            소수점배열[1] = -10.3;
            소수점배열[2] = 5.0;
            소수점배열[3] = 1;
            소수점배열[4] = -1.1;

            bool[] 참거짓배열 = new bool[10];

            참거짓배열[0] = true;




            // ctrl + k + c 블록잡고 한번에 주석
            // ctrl + k + u 블록잡고 한번에 주석 풀기

            Console.WriteLine(소수점배열);
            Console.WriteLine(소수점배열[0]);
            Console.WriteLine(소수점배열[1]);
            Console.WriteLine(소수점배열[2]);
            Console.WriteLine(소수점배열[3]);
            Console.WriteLine(소수점배열[4]);

            // 배열 범위를 넘어가면 인덱스 오류가 난다.
            //Console.WriteLine(num[5]);

            number[0] = 10;
            number[1] = 11;
            number[2] = 12;
            number[3] = 13;
            number[4] = 14;
            //number[5] = 15;

            Console.WriteLine(number[0]);
            Console.WriteLine(number[1]);
            Console.WriteLine(number[2]);
            Console.WriteLine(number[3]);
            Console.WriteLine(number[4]);
            Console.WriteLine(number[5]);

            // 문자열 배열 자료형 선언
            string[] lang = new string[5];
            // language
            // 문자열 배열 자료형 초기화
            string[] langs = { "파이썬", "C#", "Java", "한국어" };
            // languages

            // array length = 배열변수.Length -> 배열 안에 몇개 있는지 숫자로 반환

            int arrlen = langs.Length; // 유기적인 코드 수정을 원활하게 하기 위해 시스템 기능을 사용한다.
            int arrlength = 4; // 수정되는 부분을 놓칠 수 있다. / 직접 코드를 넣어주게 될 경우 오류가 발생할 수 있다.
            
            Console.WriteLine(arrlen);
            Console.WriteLine(arrlength);


            Console.WriteLine();
            Console.WriteLine();


            // 정수형 배열 자료형 초기화
            int[] num = { 3, 1, 4, 2, 5 };
            Array.Sort(num); // 정렬 오름차순     sorting 정렬 오름차순으로 정렬
            Array.Reverse(num); // 배열의 역순    reverse 거꾸로/ 배열의 끝에서부터 정렬

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }


            Console.WriteLine();
            Console.WriteLine();

            // 2차원 배열 선언
            int[,] secarr = new int[3, 3];

            // 2차원 배열 초기화
            int[,] 숫자배열 = { {1,2,3}, {4,5,6}, {7,8,9} };

            int 첫번째 = 숫자배열[0, 0];
            int 두번째 = 숫자배열[1, 2];

            int 값가져오기 = 숫자배열[2, 1];

            Console.WriteLine(값가져오기);

            Console.WriteLine(첫번째);
            Console.WriteLine(두번째);



            Console.WriteLine();
            Console.WriteLine();

            // 가변 배열
            int[][] 가변배열 = new int[3][];
            가변배열[0] = new int[] { 1, 2 };
            가변배열[1] = new int[] { 3,4,5};
            가변배열[2] = new int[] { 6,7,8,9 };

            int 첫가변배열 = 가변배열[0][1]; // 1번 층에서 2번째 칸 / 2
            int 세가변배열 = 가변배열[2][2]; // 3번 층에서 3번째 칸 / 8

            int 가변배열값 = 가변배열[1][0];

            Console.WriteLine(가변배열값);
            Console.WriteLine(첫가변배열);
            Console.WriteLine(세가변배열);

        }
    }
}
