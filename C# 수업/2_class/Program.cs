using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_class
{
    class Animal
    {
        public string Name; // 클래스 변수, 필드

        public void Sound()
        {
            Console.WriteLine("동물이 소리냅니다.");
        }
    }
    class Cat : Animal
    {
        public void Meew()
        {
            Console.WriteLine($"{Name}가 야옹 합니다.");
        }
    }

    class Moongu   // Stationery 문구류
    {
        public string Tool;
        private int amount = 10; // private, 자기 클래스 안에서만 사용
        protected string add = "추가로"; // protected, 자식 클래스에서는 접근 가능
        public void Use()
        {
            Console.WriteLine($"문구를 {amount}개 사용합니다");
        }
    }
    class Ballpen : Moongu
    {
        public void Write()
        {
            Console.WriteLine($"{Tool}로 글을 {add} 씁니다.");
        }
    }

    class Num_add
    {
        //  Overloading
        // 기존에 있던 함수에 반환형이나 매개변수에 변경이 있을 때 사용
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    // 클래스 만들고
    // 오버로딩 5개짜리 만들기
    class Politech
    { 
        public string School(string a, string b)
        {
            return a + b;
        }
        public string School(string a, string b, string c)
        {
            return a + c + b;
        }
        public string School(string a, int b, double c)
        {
            return a + b.ToString() + c.ToString();
        }
        public string School(string a)
        {
            return a;
        }
        public void School(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            cat1.Name = "아산이";
            //cat1.Sound();
            //cat1.Meew();

            // 문구류 클래스 만들고 
            // 볼펜 클래스로 상속받기
            // 변수 할당, 메서드 호출

            Ballpen mg = new Ballpen();
            mg.Tool = "모나미";
            //mg.Use();
            //mg.Write();

            Num_add num = new Num_add();
            //Console.WriteLine(num.Add(1.23, 45.6));
            //Console.WriteLine(num.Add(1, 2));
            //Console.WriteLine(num.Add(4, 5, 6));


            Politech pol = new Politech();
            Console.WriteLine(pol.School("문자", "더하기"));
            Console.WriteLine(pol.School("문자하나"));
            pol.School(1,2);
            Console.WriteLine(pol.School("문자", 1, 2.59));
            Console.WriteLine(pol.School("문", "자", "열"));
        }
    }
}
