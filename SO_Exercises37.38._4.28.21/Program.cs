using System;

namespace SO_Exercises37._38._4._28._21
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepPlaying = true;

            while (keepPlaying)
            {                 
                double[] numbers = FillArray();
                //PromptForNumbers returns an array. 

                double sum = FindSum(numbers);
                Console.WriteLine($"The sum of these numbers is {sum}");

                double average = FindAverage(numbers);
                Console.WriteLine($"The average of these numbers is {average}");

                Console.WriteLine("Would you like to continue? (y/n)");
                string userPlay = Console.ReadLine().ToLower();
                
                
                if (userPlay == "y")
                {
                    keepPlaying = true;
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                    break;
                } 
                
            }    
        }

        //EXERCISE 37: Prompt the user to enter 5 numbers. Store these numbers in  an array & output their sum

        public static double GetUserNumber(string message) // setting a method to get user data
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            double number;

            while (!double.TryParse(input, out number)) 
            {
                Console.WriteLine($"Sorry, try again. {message}");
                input = Console.ReadLine(); 
            }

            return number;
        }


        public static double[] FillArray()  // method sets up an array size 5, stores input in the array & returns the filled array
            
        {
            double[] numbers = new double[5];

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = GetUserNumber($"Provide a number for index {i}");
                }     
                
            return numbers;
        }

        public static double FindSum(double[] array)
        {
            double sum = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        public static double FindAverage(double[] array)
        {
            double average = 0;
            double sum = FindSum(array);

            for (int i = 0; i < array.Length; i++)
            {
                average =  sum / array.Length;
            }
            return average;
        }

    }
}
