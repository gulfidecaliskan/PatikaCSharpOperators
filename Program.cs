using System;
// This project was created for Patika.dev task.
namespace Operators
{
    class Program 
    {
        static void Main(string[] args)
        {
            int x = 4;
            int y = 6;
            y += 2; // Add by 2
            Console.WriteLine(y);
            y = y + 2; // Add by 2
            Console.WriteLine(y);
            y /= 1; // Divide by 1
            Console.WriteLine(y);
            x *= 3; //Multiply by 3
            Console.WriteLine(x);
            Console.WriteLine("*****Logical Operators*****");
            //Logical Operators (||,&&,!)
            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
                Console.WriteLine("Perfect!"); //If both conditions are true, print perfect
            if(isSuccess || isCompleted)
                Console.WriteLine("Great!"); //If one of the conditions is true, print great
            if(isSuccess && !isCompleted)
                Console.WriteLine("Fine!");  //If isSuccess is true and isCompleted is not true, print great
            
            Console.WriteLine("*****Relational Operators*****");
            //Relational Operators (<,>,<=,>=,!=,==)

            int a = 7;
            int b = 6;
            bool result = a < b;
            Console.WriteLine(result);
            result = a>b;
            Console.WriteLine(result);
            result = a <= b;
            Console.WriteLine(result);
            result = a >= b;
            Console.WriteLine(result);
            result = a ==b;
            Console.WriteLine(result);
            result = a != b;
            Console.WriteLine(result);
            // Arithmetical Operators (/,*,-,+)
            Console.WriteLine("*****Arithmetical Operators");

            int num = 4;
            int num2 = 8;
            int result2 = num / num2;
            Console.WriteLine(result2);
            result2 = num * num2;
            Console.WriteLine(result2);
            result2 = num + num2;
            Console.WriteLine(result2);
            result2 = num - num2;
            Console.WriteLine(result2);
            result2++;
            Console.WriteLine(result2);

            // % :used for taking mod.
            int result3 = 20 % 3;
            Console.WriteLine(result3);






        }
    }
}