using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_class
{
    class Animal
    { 
        public virtual void Speak() // 1. 접근 키워드 2. virtual, override 3.  반환형 4. 메서드 이름()
        {
            Console.WriteLine("동물이 소리냅니다");
        }
    }

    class Cat : Animal
    {
        public override void Speak() // 부모의 메서드를 재 정의
        {
            Console.WriteLine("고양이가 소리를 냅니다");
        }
    }
    class Dog : Animal
    {
        public override void Speak() // 부모의 메서드를 재 정의
        {
            Console.WriteLine("강아지가 소리를 냅니다");
        }
    }
    // 새
    // Bird
    class Bird : Animal
    {
        public override void Speak() // 부모의 메서드를 재 정의
        {
            Console.WriteLine("집에 날아갑니다");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 자식 클래스에서 재정의된 메서드를 호출
            Animal animal = new Cat();
            animal.Speak();
            Animal animal3 = new Dog();
            animal3.Speak();

            // 자기 자신 클래스에서 메서드 호출
            Cat cat = new Cat();
            cat.Speak();
            Animal animal2 = new Animal();
            animal2.Speak();
            Dog dog = new Dog();    
            dog.Speak();

            // 새 호출하기
            Animal animal5 = new Bird();
            animal5.Speak();
        }
    }
}
