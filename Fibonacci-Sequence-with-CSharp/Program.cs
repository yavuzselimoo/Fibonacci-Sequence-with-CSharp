using System;
namespace Fibonacci
{
    class Program
    {
        static void Main(String[] args)
        {
            int[] array; string input;
        Start:
            Console.Write("Enter the number of elements of the array: ");
            input = Console.ReadLine();

            if (string.IsNullOrEmpty(input) || !IsDigit(input) || Convert.ToInt32(input) < 0)
            {
                Console.WriteLine("Wrong input.");
                Thread.Sleep(1000);
                Console.Clear();
                goto Start;
            }


            //Identify the first 2 elements of the array
            array = new int[Convert.ToInt32(input)];
            switch (array.Length)
            {
                case 0:
                    Console.WriteLine("Process Completed");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                case 1:
                    array[0] = 1;
                    Console.WriteLine("Process Completed");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                case 2:
                    array[0] = 1;
                    array[1] = 1;
                    Console.WriteLine("Process Completed");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                default:
                    array[0] = 1;
                    array[1] = 1;
                    break;
            }

            Console.WriteLine("1. Element: " + array[0]);
            Console.WriteLine("2. Element: " + array[1]);
            for (int i = 2; i < array.Length; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
                //I used i+1 becouse index are starting from 0.
                Console.Write($"{i + 1}. Element: ");
                Console.WriteLine(array[i]);
            }


            //Checking is it Digit
            bool IsDigit(string input)
            {
                foreach (char c in input)
                {
                    if (!char.IsDigit(c))
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}