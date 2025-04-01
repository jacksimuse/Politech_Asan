using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<string> list = new List<string>();

            // 선언
            Dictionary<int, string> 사전 = new Dictionary<int, string>(); // key type : int, value type : string

            // 초기화
            사전.Add(1, "한국");
            사전.Add(2, "폴리텍");
            사전.Add(3, "아산");
            사전.Add(4, "캠퍼스");

            foreach (var item in 사전) // 배열, 리스트, 딕셔너리
            {
                //Console.WriteLine(item.Key + " : " + item.Value); 
            }

            // 선언과 초기화
            Dictionary<int, string> 초기화 = new Dictionary<int, string>
            {
                {1, "한국" }, {2, "폴리텍" },  {3, "아산" }, {4, "캠퍼스" }
            };

            // 초기화에 있는 요소들을 반복문을 통해 출력하기

            foreach (var item in 초기화) // 배열, 리스트, 딕셔너리
            {
                //Console.WriteLine(item.Key + " : " + item.Value);
            }

            //Console.WriteLine(사전[5]); // 없는 키를 접근하면 오류

            //변수.TryGetValue(키, out TValue 변수)
            // 키가 있으면 변수에 해당 값을 받아옴, True
            // 없으면 아무것도 못받음, False

            if (사전.TryGetValue(3, out string result))
            {
                //Console.WriteLine($"{result}이 있습니다");
            }
            else
            {
                //Console.WriteLine($"{result}이 없습니다");
            }

            if (사전.ContainsKey(6))
            {
                //Console.WriteLine($"{사전[5]} 가 있습니다");
            }
            else
            {
                //Console.WriteLine("키가 없습니다");
                사전.Add(5, "하이테크");
                //Console.WriteLine(사전[5]);
            }

            if (사전.ContainsValue("아무거나"))
            {
                //Console.WriteLine("아무거나 값이 있습니다");
            }
            else
            {
                //Console.WriteLine("아무거나 값이 없습니다");
            }

            // 값 지우기
            사전.Remove(1); //  {2, "폴리텍" },  {3, "아산" }, {4, "캠퍼스" }

            foreach (var item in 사전)
            {
                //Console.WriteLine(item.Key + " : " + item.Value);
            }

            사전.Clear();
            //Console.WriteLine(사전.Count);


            // string, string으로 딕셔너리 만들고 
            // 월, plc / 화, C# / 수, 시퀀스 / 목, Python / 금, 캐드
            Dictionary<string, string> high_class = new Dictionary<string, string>()
            {
                {"월", "plc" }, {"화", "C#" }, {"수", "시퀀스" }, {"목", "Python" }, {"금", "캐드" }
            };

            foreach (var item in high_class)
            {
                //Console.WriteLine(item.Key + " : " +  item.Value);
            }

            // 새로운 값 추가하기 (토, 게임) , (일, 운동)
            // 값 지우기 (화)
            // if문으로 키 : 수 가 있으면 "시퀀스 수업합니다" 출력
            // if문으로 밸류 : winform이 있으면 "winform 수업중" 없으면 "winform 수업해주세요"
            // if문으로 (금, out string result2) 값이 있으면 "{result2} 출력" 없으면 "수업없음"
            high_class.Add("토", "게임");
            high_class.Add("일", "운동");
            high_class.Remove("화");

            // 변수.Keys 딕셔너리의 키들만 모아옴
            Console.WriteLine("key : " + string.Join(",", high_class.Keys));
            // 변수.Values 딕셔너리의 밸류들만 모아옴
            Console.WriteLine("value : " + string.Join(",", high_class.Values));

            Console.WriteLine();

            if (high_class.ContainsKey("수"))
            {
                Console.WriteLine("시퀀스 수업합니다");
            }

            if (high_class.ContainsValue("winform"))
            {
                Console.WriteLine("winform 수업중");
            }
            else
            {
                Console.WriteLine("winform 수업해주세요");
            }

            if (high_class.TryGetValue("금", out string result2))
            {
                Console.WriteLine($"{result2} 출력");
            }
            else
            {
                Console.WriteLine("수업 없음");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // 1. 딕셔너리<double, double> 키, 밸류 3쌍 만들기
            // 2. TryGetValue(키, out double 실수) "{키} : {실수}" 출력되도록 만들기
            // 3. 변수.Keys , 변수.Values를 이용해서 모두 출력하기


            Dictionary<double, double> points = new Dictionary<double, double>()
            {
                {1.23, 45.6 }, {3.14, 99.99 }, {77.7, 88.88}
            };

            if (points.TryGetValue(1.23, out double 실수)) Console.WriteLine($"{1.23} : {실수}");
            
            Console.WriteLine();

            foreach (var point in points) { Console.WriteLine(point.Key + " : " + point.Value); }

            Console.WriteLine();

            Console.WriteLine("키 : " + string.Join(", ", points.Keys));
            Console.WriteLine("밸류 : " + string.Join(", ", points.Values));
        }
    }
}
