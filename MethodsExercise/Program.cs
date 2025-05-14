using System;

namespace MethodsExercise
{
    public class Program
    {
        // Define DayWeather method outside Main()
        static string DayWeather(string day, string activity)
        {
            return $"When the day is {day}, little Mary likes to {activity}.";
        }

        static void Main(string[] args)
        {
            // Exercise 1: Story
            string weather1 = DayWeather("sunny", "walk in the park");
            string weather2 = DayWeather("rainy", "stay home with Coco");
            string weather3 = DayWeather("windy", "doing nothing at all");

            Console.WriteLine(weather1);
            Console.WriteLine(weather2);
            Console.WriteLine(weather3);

            Console.WriteLine("What do you like to do when it's sunny?");
            string activity1 = Console.ReadLine();
            Console.WriteLine("What do you like to do when it's rainy?");
            string activity2 = Console.ReadLine();
            Console.WriteLine("What do you like to do when it's windy?");
            string activity3 = Console.ReadLine();
            Console.WriteLine("And on one of those weathers, do you like to walk your dog?");
            string DogWalk = Console.ReadLine();

            // Exercise 2: Math operations methods
            int a = 10;
            int b = 5;
            int addition = AddingTwoNumbers(a, b);
            int multiplication = MultiplyTwoNumbers(a, b);
            int substraction= SubsTwoNumbers(a, b);
            int division = DivTwoNumbers(a,b);

            Console.WriteLine($"When a equals {a}, and b equals {b}, when added it equals {addition}.");
            Console.WriteLine($"In a substraction, when {b} is substracted from {a}, the result is {substraction}.");
            Console.WriteLine($"When {a} is multiplied by {b}, the result is equal to {multiplication}.");
            Console.WriteLine($"But when {a} is divided by {b}, the result is equal to {division}.");
        }

        public static int AddingTwoNumbers(int a, int b)
        {
            return a + b;
        }

        static int MultiplyTwoNumbers(int a, int b)
        {
            return a * b;
        }

        static int SubsTwoNumbers(int a, int b)
        {
            return a - b;
        }

        static int DivTwoNumbers(int a, int b)
        {
            return a / b;
        }
    }
    
}