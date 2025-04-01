using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_list
{
    class Program
    {
        static void Main(string[] args)
        {
            // 문자열 전용 리스트 
            // 선언 
            List<string> list = new List<string>();

            // 모든 자료형용 리스트 만들기
            List<object> list2 = new List<object>();

            list2.Add(1);
            list2.Add(2);
            list2.Add(3);
            list2.Add("a");
            list2.Add("b");
            list2.Add("c");

            list2.Remove("a");

            // 선언과 초기화 
            List<object> list3 = new List<object>
            {   "a",
                "b",
                "c",
                1,
                2,
                3
            };

            List<dynamic> list4 = new List<dynamic>
            {   "a","b","c",1,2,3 };

            // list = [ "a","b", "c", 1,2,3, ["e", "f", "g", 4, 5, 6]] 파이썬 코드
            //List<object> 이중리스트 = new List<object>
            //{  "a","b", "c", 1,2,3,
            //    new List<string> {"e", "f", "g"}
            //};

            // object > List

            //List<object> 이중리스트_안_리스트 = (List<object>)이중리스트[6];

            // Console.WriteLine(이중리스트_안_리스트[0]);

            //List<object> 문자이중리스트 = new List<object>
            //{
            //    "한국", "폴리텍", "아산", "캠퍼스",
            //    new List<string> { "안녕", "하세요"}
            //};

            //List<object> 이중문자리스트_안_리스트 = (List<object>)문자이중리스트[4];


            // 바깥 리스트 List<object> 
            // 안쪽 리스트 List<int>

            List<object> outlist = new List<object>  // outlist 바깥 리스트라는 의미 
            {
                1,2,3, "C#", "파이썬",
                new List<int> {4,5,6}
            };

            //Console.WriteLine(outlist[0]);
            //Console.WriteLine(outlist[5]);

            // 명시적 형변환      (자료형)변수
            List<int> intlist = (List<int>)outlist[5]; // {4,5,6}

            // Console.WriteLine(intlist[0]);



            // object로 바깥 리스트 만들고
            // string list 만들어서 리스트 안의 값에 접근하기
            List<object> outlist2 = new List<object>
            {
                "바깥", "리스트",
                new List<string> { "한국", "폴리텍"}
            };

            // 이중리스트로 만들어진 내부 리스트를 가져오는 과정
            // 내부 리스트와 자료형을 일치하게 변수를 만들어주고 형변환도 해준다
            // List<자료형> 변수 = (List<자료형>)변수[인덱스];
            List<string> stringlist = (List<string>)outlist2[2]; // { "한국", "폴리텍"}

            // 리스트에 담긴 값에 접근하기 위해 인덱스 사용
            //Console.WriteLine(stringlist[0]);


            //Console.WriteLine(((List<string>)outlist2[2])[0]);

            // "10"
            //Console.WriteLine((10.ToString()).Length);


            // object > List
            // 이중리스트를 만들 때 List<object> { new List<자료형>}  -> new List<자료형> object

            // 1. 이중 리스트를 만들고 내부 리스트는 string으로 만들어 봅시다.
            // 2. 내부 리스트를 받을 수 있는 새로운 리스트를 만들고 변수에 담아줍시다.
            // 3. 새로 담긴 리스트를 인덱스를 사용하여 요소 접근해봅시다.
            // 4. 리스트의 모든 요소를 출력해봅시다.

            List<object> subject = new List<object>
            {
                1,2,3, new List<string> {"1교시", "2교시", "3교시"}
            };

            List<string> times = (List<string>)subject[3];
            Console.WriteLine(times[0]);
            
            foreach (string s in times)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            Console.WriteLine(string.Join(" ", times));
        }
    }
}
