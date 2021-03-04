using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
