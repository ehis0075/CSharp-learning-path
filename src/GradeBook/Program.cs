﻿using System;

namespace GradeBook
{

    // static void PassByRef(ref int i)
    // {
    //    i = i + 1; 
    // }

            // // enum
            // enum Status 
            // {
            //     Alive, 
            //     Injured,
            //     Dead
            // }

            //struct
            // 
            
            // using this keyword

            // struct Vector 
            // {
            //     public Vector(int a, int b)
            //     {
            //         this.a = a;
            //         this.b = b;
            //     }

            //     // fields
            //     public int a;
            //     public int b;
            // }



            // class            
            // class Person
            // {
            //     public string name;
            //     public int age;

            //     public void Display()
            //     {
            //         Console.WriteLine("My name is {0} and my Age is {1}", name,age);
            //     }
            // }

            // class Person 
            // {
            //     public string name;
            //     public int age;

            //     //default constructor
            //     public Person()
            //     {
            //         name = "NILL";
            //         age = -1;
            //     }
            // }

            // base constructor
            // class Person 
            // {
            //     protected string name;
            //     protected int age;

            //     public Person(string name, int age)
            //     {
            //         this.name = name;
            //         this.age = age;
            //     }
            // }

            // class Employee : Person
            // {
            //     public Employee(string n, int a) : base(n, a)
            //     {
            //         Console.WriteLine("this is working");
            //     }
            // }

            //  // static type
            // static class Helper 
            // {
            //     public static void add()
            //     {
            //         Console.WriteLine("adding......");
            //     }
            // }

//             //static constructor
//            static class Helper 
//            {
//                public static int age;

//                static Helper()
//                {
//                    age = 23;
//                }

// `               public static void add()
//                 {
//                     Console.WriteLine("adding......");
//                 }

//            }

            // extension method in static type
            // public static class ExtensionClass
            // {
            //     public static bool isLessThan(this int origin, int compareValue)
            //     {
            //         if(origin < compareValue)
            //             return true;
            //         else
            //             return false;
            //     }
            // }


            
            // User defined implicit type conversion

            // // implicit user definened type conversion
            //  class Byte
            //  {
            //      public int bits = 8;
            //      public static implicit operator int(Byte b)
            //      {
            //          return b.bits;
            //      }
            //  }

            // User defined explicit type conversion
            class Person 
            {
                public int Age { get; set; }
                public string Name { get; set; }

                public static explicit operator string (Person per)
                {
                    return per.Name;
                }
            }



    class Program
    {
        static void Main(string[] args)
        {

            // // extension method
            // int age = 22;
            // bool check = age.isLessThan(30);
            // Console.WriteLine(check);




            // type conversion

              // User defined implicit type conversion

            // Byte b = new Byte();
            // int totalBits = b;
            // Console.WriteLine(totalBits);


             // User defined explicit type conversion
             Person per = new Person { Age = 22, Name = "Ali" };

             string name = (string)per;
             Console.WriteLine(name);


            // // as operator
            // class A 
            // {

            // }

            // class B : A 
            // {

            // }

            // A a = new B();

            // // explicitly convert type A to B
            // //B b = a as B;


            // // is operator
            // if(a is B)
            // {
            //     B b = (B)a;
            // }

            // Console.WriteLine(b.GetType());




            /** if else statement
            int age = 20;

            if(age< 11)
            {
                Console.WriteLine("You are a child");
            }

            else if(age < 18)
            {
                Console.WriteLine("You are an adult");
            }

            else
            {
                Console.WriteLine("you are an old man");
            }
            **/

            /**
            int i = 3;

            switch(i%2)
            {
                case 0:
                        Console.WriteLine("{0} is an even number", i);
                break;

                case 1:
                        Console.WriteLine("{0} is an odd number", i);
                break;                
            }
            **/


            /**conditional operator 
            int num = 2;
            string result = (num % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine("{0} is {1}", num, result);

            **/

             /**Null Coalescing operator 
             string name = null;

             string username = name ?? "user";

            **/

            /**
            bool isFound = false;
            int value = 0;

            while(isFound != true)
            {
                if(value == 25)
                {
                    isFound = true;
                }
                value = value + 5;
            }

            **/


            /** for loop
            for(int count =1; count <= 5; count++)
            {
                Console.WriteLine("hello...");
            }
            
            **/

            /** goto
            char chair = 't';

            switch(chair)
            {
                case 'a':
                    {
                        Console.WriteLine("chair is a vowel.");
                        break;
                    }
                case 'e':
                    {
                        goto case 'a';
                    }    
                case 'i':
                    {
                        goto case 'a';
                    }    
                case 'o':
                    {
                        goto case 'a';
                    }    
                case 'u':
                    {
                        goto case 'a';
                    }
                case 'y':
                    {
                        Console.WriteLine("Chair is sometimes a vowel.");
                        break;
                    }        
                default:
                    {
                        Console.WriteLine("chair is a consonant");
                        break;
                    }    
            }

            

           int[] num = new int[] {1,2,3,4,5,6,7,8,9,10};

            for(int i = 0; i < 10; i++)
            {
                if(num[i] == 8)
                {
                    goto Control;
                }
            }

            Console.WriteLine("end of loop");

            Control:
            Console.WriteLine("the number is 8");


           

            int sum(int a, int b = 2)
            {
                int add = a + b;
                return add;
            }

            Console.WriteLine("the sum of a and b is {0}", sum(2,5));

             ***/


            // int Sum(params int[] args)
            // {
            //     int add = 0;

            //     foreach (int item in args)
            //     {
            //         add = add + item;
            //     }

            //     return add;
            // }

            // TYPES IN C#

            // Status player = Status.Alive;
            
            // //enum
            // switch(player)
            // {
            //     case Status.Alive:
            //         Console.WriteLine("i am alive");
            //         break;

            //     case Status.Injured:
            //         Console.WriteLine("i am injured");
            //         break;
            //     case Status.Dead:
            //         Console.WriteLine("i am dead");
            //         break;            
            // }

            // int valueOfAlive = (int)Status.Alive;
            // Console.WriteLine(valueOfAlive);


            // struct
            // Vector vector = new Vector();
            // vector.x = 4;
            // vector.y = 2;

            // Console.WriteLine("X = {0}", vector.x);
            // Console.WriteLine("Y = {0}", vector.y);

            // using constructor in struct
            // Vector v = new Vector(2,10);

            // Console.WriteLine("x = {0}", v.x);
            // Console.WriteLine("y = {0}", v.y);


            // // class
            // Person p = new Person();
            // p.name = "ehis jude";
            // p.age = 20;

            // p.Display();

            //Employee emp = new Employee("Hamza", 20);

            //anonymous class
            // var person = new { Name = "ali", age = 22};

            // Console.WriteLine("Name = {0}", person.Name);
            // Console.WriteLine("Age = {0}", person.age);


            // dynamic type
           // dynamic name = "ehis";
           // Console.WriteLine(name.GetType());


            // // nullable type
            // bool? isMarried = null;
            // isMarried = true;

            // // using ?? operator
            // bool? isBig = null;
            // bool big = isBig ?? false;

            // Nullable<bool> isSmall = null;   OR bool? isSmall = null;


            // // static type
            // static class Helper 
            // {
            //     public static void add()
            //     {
            //         Console.WriteLine("adding......");
            //     }
            // }


           // Helper.add();

           







            
        }
    }
}
