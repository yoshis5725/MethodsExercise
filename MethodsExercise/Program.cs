using System;

namespace MethodsExercise
{
    class Program
    {

        public static void UserInfo()
        {
            Console.WriteLine("What is your name? ");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your favorite color? ");
            string userColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal? ");
            string userAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite band? ");
            string userBand = Console.ReadLine();

            Console.WriteLine($"Good morning, {userName}! I once dreamt that that I was a {userAnimal} on a far far away planet jamming out to {userBand} in my {userColor} sunglasses");
        }


        // Math operator methods

        public static void Sum(params int[] args)
        {
            int sum = 0;

            foreach (int arg in args)
            {
                sum += arg;
            }

            Console.WriteLine($"Addition results ---> {sum}");
        }


        public static void Subtract(int num1, int num2, int[] additionalNumbers = null)
        {
            int results = num1 - num2;

            if (additionalNumbers != null)
            {
                foreach (int num in additionalNumbers)
                {
                    results -= num;
                }
            }

            Console.WriteLine($"Subtraction results ---> {results}");
        }


        public static void Multiply(params int[] args)
        {
            int results = 1;
            
            foreach (int arg in args)
            {
                results *= arg;
            }

            Console.WriteLine($"Mulitply results ---> {results}");
        }


        public static void Divide(int num1, int num2, int[] additionalNumbers = null)
        {
            int results = num1 / num2;

            if (additionalNumbers != null)
            {
                foreach (int num in additionalNumbers)
                {
                    results /= num;
                }
            }

            Console.WriteLine($"Divide results ---> {results}");
        }


        public static void Modulus(int num1, int num2, int[] additionalNumbers = null)
        {
            int results = num1 % num2;

            if (additionalNumbers != null)
            {
                foreach (int num in additionalNumbers)
                {
                    results %= num;
                }
            }

            Console.WriteLine($"Modulus results ---> {results}");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("------- Exercise One -------");
           // UserInfo();

            Console.WriteLine("------- Exercise Two -------");
            Sum(2, 4, 6, 78);
            Subtract(10, 3, new int[] {3});
            Multiply(10, 2, 2);
            Divide(100, 2, new int[] {2, 2});
            Modulus(12, 5);

        }
    }
}

