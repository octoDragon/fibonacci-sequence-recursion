using System;

namespace FibonacciSequence
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            //fields
            int a = 0; //first number of the Fib. Sequence  
            int b = 1; //second number of the Fib. Sequence 



            Console.Write("What fibonacci number do you want to go to?" + "\n--> ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            //prevents negative integer user inputs 
            while (userInput < 1) //at index 0, the input is equal to -3 because we subract it when Fibonacci is initially called 
            {
                Console.WriteLine("Please try again with a postive integer index.");
                Console.Write("--> ");
                int newInput = Convert.ToInt32(Console.ReadLine());
                userInput = newInput;
                
            }

            int value = Fibonacci(a, b, (userInput-3)); // userInput-3 to account for the "a" and "b" predefined indexes
            Console.WriteLine("\nThe " + userInput + " Fib. number is: " + value);

        }

        public static int Fibonacci(int a, int b, int input) 
        {
            int c; //c will store one of the pieces, while the other is being changed 
            c = a + b; //will get the next number in the progression

            if(input == -2)//first number in the sequence (0)
            {
                return a;
            }

            if (input == -1)//second in the sequence 1
            {
                return b;
            }

            if (input < 1)//for index's larger than 3
            {
                return c;
            }
            return Fibonacci(b, c, input - 1);//using recurion we keep b and use the new value c in the next Fibonacci call
        }
    }
}












        
