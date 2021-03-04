using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

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

            **/

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


            

        }
    }
}
