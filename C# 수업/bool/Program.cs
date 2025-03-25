using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @bool
{
    class Program
    {
        static void Main(string[] args)
        {
            bool avocado = true;

            if (avocado)
            {
                Console.WriteLine("우유 사와");
            }

            // bool을 사용해서 "눈" 변수에 true를 넣고 if를 이용해서 "우산 챙기세요" 출력
            bool 눈 = true;
           
            if (눈)
            {
                Console.WriteLine("우산 챙기세요");
            }

            // bool을 사용해서 "비" 변수에 false를 넣고 if를 이용해서 "비 안와요" 출력
            bool 비 = false;
            if (비)
            {
                Console.WriteLine("비 안와요");
            }
        }
    }
}
