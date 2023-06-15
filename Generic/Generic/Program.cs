using System;
using System.Collections.Generic;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            //Action<string> Print = PrintSomeThing;
            //Print("Salam");

            //Task2
            //Func<int, int> power = PowerNumber;
            //Console.WriteLine(power(5));

            //Task3
            //Predicate<int> function = IsEven;
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 67, 8 };
            //PrintEvenNumber(numbers, function);

            //Task4
            //Action<int> func = AddNumber;
            //List<int> numbers = new List<int> { 1, 2, 3, 45, 6 };
            //ChangeList(numbers, func);
         
            //Task5
            //Action<int> action = PowerOfNumber;
            //Action<int> action1 = SumOfNumbers;
            //// { action, action1, action2, action3, action4 }
            //List<Action<int>> actions = new List<Action<int>>() { action, action1 };

            //Task6
            // Predicate<string> predicate = LenghtGreateThanSix;
            //List<string> names = new List<string> { "Faig", "Samir", "Shamxal" };
            //Filter(names, predicate);
        }
        public static void Filter(List<string> names, Predicate<string> predicate)
        {
            foreach (var item in names)
            {
                if (LenghtGreateThanSix(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
        public static bool LenghtGreateThanSix(string item)
        {
            if (item.Length > 6)
            {
                return true;
            }
            return false;
        }
    }
        public static void PowerOfNumber(int number)
        {
            Console.WriteLine(number * number);
        }
        public static void SumOfNumbers(int num1)
        {
            Console.WriteLine(num1 + 2);
        }
        public static void ChangeList(List<int> numbers, Action<int> func)
        {
            foreach (var item in numbers)
            {
                func(item);
            }
        }
        public static void AddNumber(int item)
        {
            Console.WriteLine(item + 1);
        }
        public static void PrintEvenNumber(List<int> numbers, Predicate<int> function)
        {
            foreach (var item in numbers)
            {
                if (function(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
        public static bool IsEven(int item)
        {
            return item % 2 == 0;
        }


        public static int PowerNumber(int num)
        {
            return num * num;
        }
        static void PrintSomeThing(string word)
        {
            Console.WriteLine(word);
        }
    }
}
