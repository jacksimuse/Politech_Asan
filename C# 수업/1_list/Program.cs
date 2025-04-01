using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_list
{
    class Program
    {
        static void Main(string[] args)
        {
            // 선언
            List<string> 학교 = new List<string>();

            string 변수;

            // 초기화
            변수 = "초기화";


            // Add는 만들어진 리스트에 가장 뒤에 값이 붙는다.
            학교.Add("한국");
            학교.Add("폴리텍");
            학교.Add("아산");
            학교.Add("캠퍼스");

            for (int i = 0; i < 학교.Count; i++)
            {
                Console.WriteLine(학교[i]);
            }

            Console.WriteLine(학교[0]);
            Console.WriteLine(학교[1]);
            Console.WriteLine(학교[2]);
            Console.WriteLine(학교[3]);


            // 선언과 동시에 초기화
            List<string> 학교2 = new List<string> { "한국", "폴리텍", "아산", "캠퍼스" };


            // 1. 정수형 리스트를 선언
            // 2. 정수형 리스트를 초기화
            // 3. 정수형 리스트를 선언과 동시에 초기화

            List<int> 숫자리스트 = new List<int>();
            숫자리스트.Add(1);
            숫자리스트.Add(2);
            숫자리스트.Add(3);
            숫자리스트.Add(4);
            숫자리스트.Add(5);
            숫자리스트.Add(6);
            숫자리스트.Add(7);
            숫자리스트.Add(8);
            숫자리스트.Add(9);
            숫자리스트.Add(10);


            for (int i = 0; i < 숫자리스트.Count; i++)
            {
                Console.WriteLine(숫자리스트[i]);
            }
            Console.WriteLine();

            List<int> 숫자리스트2 = new List<int> { 1, 2, 3, 4, 5 };

            for (int i = 0; i < 숫자리스트2.Count; i++)
            {
                Console.WriteLine(숫자리스트2[i]);
            }

            // Insert
            // Insert는 해당 위치에 자리를 만들어 값은 집어넣습니다.
            숫자리스트.Insert(1, 10);
            Console.WriteLine(숫자리스트[3]);
            Console.WriteLine(숫자리스트.Count);
            Console.WriteLine();

            for (int i = 0; i < 숫자리스트.Count; i++)
            {
                //Console.WriteLine(숫자리스트[i]);
            }

            // Remove
            // 리스트에서 가장 먼저 발견되는 값을 제거
            숫자리스트.Remove(10);
            Console.WriteLine(숫자리스트.Count);

            for (int i = 0; i < 숫자리스트.Count; i++)
            {
                Console.WriteLine(숫자리스트[i]);
            }

            숫자리스트.RemoveAt(1);
            Console.WriteLine(숫자리스트.Count);

            Console.Write(string.Join(" ", 숫자리스트));
            Console.WriteLine();

            //Sort()
            // Reverse()
            숫자리스트.Sort();
            숫자리스트.Reverse();

            Console.Write(string.Join(" ", 숫자리스트));
            Console.WriteLine();

            Console.WriteLine(숫자리스트.IndexOf(3));
            숫자리스트.Clear();
            Console.WriteLine(숫자리스트.Count);


            // Add(값), Insert(위치, 값), Remove(값), RemoveAt(위치), IndexOf(값), Sort(), Reverse(), Clear(), Count

            // 1. 정수형 리스트를 만들고 값을 추가해보도록 합니다. 1,2,3
            List<int> 정수리스트 = new List<int>();
            정수리스트.Add(1);
            정수리스트.Add(2);
            정수리스트.Add(3);
            // 2. 요소들을 가지고 사칙연산을 해봅시다. 결과 값은 $"{변수[위치]} + {변수[위치]} = {변수[위치] + 변수[위치]} "
            Console.WriteLine($"{정수리스트[0]} + {정수리스트[1]} = {정수리스트[0] + 정수리스트[1]} ");
            Console.WriteLine($"{정수리스트[0]} - {정수리스트[1]} = {정수리스트[0] - 정수리스트[1]} ");
            Console.WriteLine($"{정수리스트[0]} * {정수리스트[1]} = {정수리스트[0] * 정수리스트[1]} ");
            Console.WriteLine($"{정수리스트[0]} / {정수리스트[1]} = {정수리스트[0] / 정수리스트[1]} ");
            // 3. 요소들에 새롭게 값을 삽입하고 값은 10, 20, 30을 넣어봅시다.
            정수리스트.Insert(1, 10);
            정수리스트.Insert(0, 20);
            정수리스트.Insert(2, 30);
            // 4. 반복문을 통해 요소들을 확인해봅시다. 변수.Count 사용
            Console.WriteLine();
            for (int i = 0; i < 정수리스트.Count; i++)
            {
                Console.WriteLine(정수리스트[i]);
            }
            Console.WriteLine();
            //// 5. 조건문을 사용해서 리스트 값이 5개 이하면 "더 추가해주세요", 10개 이하면 "충분합니다", 나머지는 "리스트 완성"
            if (정수리스트.Count <= 5)
            {
                Console.WriteLine("더 추가해주세요");
            }
            else if (정수리스트.Count <= 10)
            {
                Console.WriteLine("충분합니다");
            }
            else
            {
                Console.WriteLine("리스트 완성");
            }

            // Contains(값) 값이 포함되어있는지 확인
            if (정수리스트.Contains(1000))
            {
                Console.WriteLine($"10이라는 값은 {정수리스트.IndexOf(10)}에 위치하고 있습니다.");
            }
            else
            {
                Console.WriteLine($"10이라는 값은 없습니다");
            }
            
            
               

        }
    }
}
