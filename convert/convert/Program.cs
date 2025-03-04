using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 형변환
            // 1. 암시적 형변환
            int a = 20;
            double b = a;
            Console.WriteLine(b);
            Console.WriteLine(); // 값 형식인지 확인

            // 변수 a와 b의 타입 출력
            Console.WriteLine("변수 a의 타입: " + a.GetType());
            Console.WriteLine("변수 b의 타입: " + b.GetType());

            // 2. 명시적 형변환  
            double c = 20.5;
            int d = (int)c;
            Console.WriteLine(d);
            Console.WriteLine();
            Console.WriteLine("변수 c의 타입: " + c.GetType());
            Console.WriteLine("변수 d의 타입: " + d.GetType());

            double e = 10.04567;
            float f = (float)e;
            Console.WriteLine(f);
            Console.WriteLine();
            Console.WriteLine("변수 e의 타입: " + e.GetType());
            Console.WriteLine("변수 f의 타입: " + f.GetType());

            // 3. Parse() 메서드
            string g = "20";
            int h = int.Parse(g);
            Console.WriteLine(h);
            Console.WriteLine();
            Console.WriteLine("변수 g의 타입: " + g.GetType());
            Console.WriteLine("변수 h의 타입: " + h.GetType());

            // 4. TryParse() 메서드
            string i = "30";
            int j;
            bool result = int.TryParse(i, out j);
            if (result)
            {
                Console.WriteLine(h);
            }
            else
            {
                Console.WriteLine("변환 실패");
            }

            Console.WriteLine();
            Console.WriteLine("변수 i의 타입: " + i.GetType());
            Console.WriteLine("변수 j의 타입: " + j.GetType());

            // 5. Convert 클래스
            string k = "40.456";
            double l = Convert.ToDouble(i);
            Console.WriteLine(j);
            Console.WriteLine();
            Console.WriteLine("변수 k의 타입: " + k.GetType());
            Console.WriteLine("변수 l의 타입: " + l.GetType());


        }
    }
}
