using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 반복문
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1번 / int i = 0; 몇번 반복할거야에서 몇번을 담을 그릇
            // 2번 / i < 3; 몇번을 실행할지 조건을 걸어줌
            // 3번 / i++ 반복 차수를 늘려줌
            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine(i);
            }

            // Console.WriteLine(i);  for() 안에서 선언된 변수는 안에서만 사용 가능

            // i++ -> 기존에 있던 i 값에 + 1을 해라

            // for() 밖에서 만들어진 변수는 안과 밖에서 둘다 사용 가능

            Console.WriteLine();
            Console.WriteLine();

            int j = 0;
            for (j = 0; j < 3; j++)
            {
                Console.WriteLine(j);
            }

            Console.WriteLine(j);

            for (j = 3; j > 0; j--)
            {
                Console.WriteLine(j);
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 1; i < 10; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 10; i > 0; i -= 2)
            {
                Console.WriteLine(i);
            }

        }
    }
}
