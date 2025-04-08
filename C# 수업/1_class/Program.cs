using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1_class
{
    class Person // class 클래스명
    {
        // 클래스 변수, 해당 클래스에서만 사용하는 변수
        public string Name;
        public int Age;

        // 생성자
        public Person(string name, int age) // 생성자 기본형, public 클래스명()
        {
            Name = name;
            Age = age;
        }
        // 메서드
        public void Introduce()
        {
            Console.WriteLine($"안녕하세요 저는 {Name}이고, 나이는 {Age}입니다");
        }
    }
    class Car
    {
        // 클래스 변수
        public string Model;
        public int Year;

        // 생성자
        public Car(string model, int year)
        {
            Model = model;
            Year = year;
        }

        public void Make()
        {
            Console.WriteLine($"올해 {Year}년식 자동차 {Model}이 생산될 예정입니다.");
        }
    }
    // 동물 클래스 만들고 초기화, 호출하기
    class Animal
    {
        public string Category;
        public int Leg;
    
        public Animal(string category, int leg)
        {
            Category = category;
            Leg = leg;
        }

        public void Check()
        {
            Console.WriteLine($"동물 분류 : {Category}, 다리 수 : {Leg}");
        }
    }

    class Employee
    {
        private string file; // file 클래스 변수
        public string File
        {
            get { return file; } // 클래스 변수를 호출할 때 get에 도달
            set // 클래스 변수에 값이 할당될때 set에 도달
            {
                if (value == "결재서류")
                {
                    file = "승인";
                }
                else
                {
                    file = value;
                }
            }
        }
    }

    class Num_add
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    class Bank
    {
        private int account; // private  외부에서 접근 불가능

        public int Account
        {
            get { return account; }
            set 
            { 
                if (value == 0)
                {
                    account = 1;
                }
                else if (value > 0)
                {
                    account = value;
                }
            }
        }

        public void Deposit(int money)
        {
            if (money > 0)
            {
                account += money;
                Console.WriteLine($"현재 {money}원이 입금되어서 잔고에 {account}원 있습니다.");
            }
            else if (money == 0)
            {
                Console.WriteLine("돈 가져오세요");
            }
            else
            {
                Console.WriteLine("적자입니다.");
            }
        }
        public void Withdraw(int money2) // 계좌에 얼마 있는지 모름, money2 = 10000을 출금하려고 합니다
        {
            if (money2 >= account)
            {
                Console.WriteLine("출금 못함");
            }
            else
            {
                account -= money2;
                Console.WriteLine($"{money2}만큼 출금되었습니다. 현재 계좌에는 {account} 남았습니다");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("최재훈", 20); // 객체1 생성
            
            p1.Name = "다른이름"; // class Person에 있는 Name에 새로운 값 대입
            p1.Age = 10; // class Person에 있는 Age에 새로운 값 대입
            // p1.Name; 대입, 호출, 증가, 감소 오류는  = 할당하거나, 값을 불러주기만하거나, 증감연산자 사용해서 이용

            Person p2 = new Person("거북이", 100); // 객체2 생성


            string name = "최재훈";
            int age = 20;

            //Console.WriteLine($"안녕하세요 저는 {name}이고, 나이는 {age}입니다");

            //Console.WriteLine($"{p1.Name}는 사과를 {p1.Age} 개 먹었습니다.");
            //Console.WriteLine($"{p2.Name}는 사과를 {p2.Age} 개 먹었습니다.");

            // Car 클래스를 이용해서 객체 1,2 만들기
            Car c1 = new Car("테슬라", 25);
            Car c2 = new Car("벤츠", 30);

            // Car 클래스에 접근하여 Make함수 호출
            //c1.Make();
            //c2.Make();


            c1.Model = "접근가능";

            Animal a1 = new Animal("포유류", 4);
            Animal a2 = new Animal("조류", 2);

            //a1.Check();
            //a2.Check();


            Employee ee = new Employee();
            //ee.Salary = 100; // 클래스 변수에 값을 할당할 때 set에 도달
            //Console.WriteLine(ee.Salary); // 클래스 변수를 호출할 때 get에 도달

            //ee.Salary = -100;
            //Console.WriteLine(ee.Salary); // 클래스 변수를 호출할 때 get에 도달


            // 3. 클래스를 통해 객체를 생성하고 값을 할당하고 값을 받아오기

            Employee ee2 = new Employee();
           // ee2.Car = "전기차";
            //ee2.Car = "기름차";
            //Console.WriteLine(ee2.Car);

            
            Employee ee3 = new Employee();
            ee3.File = "결재서류";
           // Console.WriteLine(ee3.File);
            ee3.File = "양서류";
            Console.WriteLine(ee3.File);


            Num_add na = new Num_add();
            int num = na.Add(1, 2);
            Console.WriteLine(num);


            Bank bk = new Bank();
            bk.Account = 10000;
            Console.WriteLine(bk.Account);
            bk.Deposit(5000);
            bk.Withdraw(20000);
        }
    }
}
