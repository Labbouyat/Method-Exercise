using System;

namespace MethodExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your Favorite Color?");
            string FavoriteColor = Console.ReadLine();

            Console.WriteLine("What is your Favorite Animal?");
            string FavoriteAnimal = Console.ReadLine();

            Console.WriteLine("What is your Favorite Band?");
            string FavoriteBand = Console.ReadLine();

            Console.WriteLine($" Your name is {userName}, You like the {FavoriteColor} color, your Favorite Animal is {FavoriteAnimal}, you like {FavoriteBand} Band. ");

            Console.WriteLine("Give a number to Add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give a number to Add to the first");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine("give a number");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("give a number to multiply to the first one");
            int y = int.Parse(Console.ReadLine());

            int multiply = Multiply(x, y);
            Console.WriteLine($"The Multiply is: {multiply}");

            int Y = Add(2, 4);
            Console.WriteLine(Y);

            int X = Add(2, 4, 6);
            Console.WriteLine(X);

            int P = Add(1, 1, 1, 1, 1);
            Console.WriteLine(P);
        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Add(params int[] ListNumber)

        {
            int total = 0;
            foreach (int i in ListNumber)
            {
                total += i;
            }
                return total;
        }

    }
    
}
