using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            //int 나이 = 20;
            //string 민증검사 = (나이 > 20) ?  "성인"  :  "미성년자";
            //Console.WriteLine(민증검사);

            // 날짜가 25일 임을 확인하기 위해 삼항연산자를 사용합니다.
            // int 오늘 25일 초기화 해주고 25보다 크고 작음을 판단하여 맞으면 "지났습니다." 틀렸으면 "아직" 출력
            int 오늘 = 25;
            string 수업날짜 = (오늘 >= 25) ? "지났습니다" : "아직";
            Console.WriteLine(수업날짜);
        }
    }
}
