using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 조건문
{
    class Program
    {
        static void Main(string[] args)
        {
            string 조건문 = "안녕하세요.";

            // 맞는지 틀린지 알 수 있는 조건만 넣어주면 된다.
            if (조건문.Length > 5) // 조건문.Length는 지금 5입니다. 5 > 5 ?
            {
                Console.WriteLine("조건문은 5자를 넘겼습니다.");
            }
            else
            {
                Console.WriteLine("조건문은 4자를 넘겼습니다.");
            }

            int 점수 = 85;
           
            if (점수 >= 90)
            {
                Console.WriteLine("A학점 입니다.");
            }
            else if (점수 >= 80)
            {
                Console.WriteLine("B학점 입니다.");
                
            }
            else
            {
                Console.WriteLine("학점이 없습니다.");
            }


            // switch 조건문
            string 요일 = "화요일";


            // switch (변수)
            // case로 조건을 달아줌 실행하고자 하는 코드가 끝나면 break; 를 꼭 넣어주세요
            // default(기본값) 
            switch (요일)
            {
                case "월요일": // case "변수에 대한 조건": 
                    Console.WriteLine("오늘은 월요일입니다."); // 조건에 맞을 때 실행할 코드
                    break; // 코드를 마치기 위한 탈출 문자
                case "화요일":
                    Console.WriteLine("오늘은 화요일입니다.");
                    break;
                case "수요일":
                    Console.WriteLine("오늘은 수요일입니다.");
                    break;
                case "목요일":
                    Console.WriteLine("오늘은 목요일입니다.");
                    break;
                case "금요일":
                    Console.WriteLine("오늘은 금요일입니다.");
                    break;
                case "토요일":
                    Console.WriteLine("오늘은 토요일입니다.");
                    break;
                default:
                    Console.WriteLine("오늘은 일요일입니다.");
                    break;
            }

            int 숫자 = 11;
            switch (숫자)
            {
                case 1:
                    Console.WriteLine("숫자는 1입니다.");
                    break;
                case 10:
                    Console.WriteLine("숫자는 10입니다.");
                    break;
                case 11:
                    Console.WriteLine("숫자는 11입니다.");
                    break;
                default:
                    Console.WriteLine("모르는 숫자입니다.");
                    break;
            }
        }
    }
}
