using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop__
{
    class Calculator
    {
        public void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"Result = {result}");
        }
        public void Add(int a, int b, int c)
        {
            int result = a + b+ c;
            Console.WriteLine($"Result = {result}");
        }
        public int Add(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
    }
    class Person
    {
        public string name;
        private int age;
        private int salary=100;

        public string Surname { get; set; } = "Hello";
        public int Age
        {
            get { return age; }
            set {
                if (value < 0)
                {
                    this.age = 0;
                }
                else if (value > 120)
                {
                    this.age = 120;
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public Person(): this("Noname", 33,1000)
        {
        }
        public Person(string name, int age, int salary)
        {
            this.name = name;
            this.Age = age;
            this.salary = salary;
        }   
        public Person(string name, int age): this(name, age, 1000)
        {
        }
        public static bool operator == (Person p1, Person p2)
        {
            return p1.Age == p2.Age;
        }
        public static bool operator != (Person p1, Person p2)
        {
            return p1.Age != p2.Age;
        }
        public static bool operator ==(Person p1, int a)
        {
            return p1.Age == a;
        }
        public static bool operator !=(Person p1, int a)
        {
            return p1.Age != a;
        }
        public static bool operator ==(int a, Person p1)
        {
            return p1.Age == a;
        }
        public static bool operator !=(int a, Person p1)
        {
            return p1.Age != a;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Person's name {this.name} age {this.Age}");
        }
        public override string ToString()
        {
            return $"Person's name {this.name} age {this.Age}";
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int x = 5;
            int y = 0;
            int z = x / y;
            
            //Person per1 = new Person();
            //Person per2 = new Person("Ivan", 37, 5000);
            //Person per3 = new Person("Ivan", 37);
            //Calculator calc = new Calculator();
            //calc.Add(15, 29);
            //int res = calc.Add(1, 2, 3, 4);
            //Console.WriteLine(per2 == per3);
            //Console.WriteLine(100 == per1);
            //Console.WriteLine(per1.ToString());
            ////per1.PrintInfo();
            Console.ReadLine();
            
        }
    }
}
