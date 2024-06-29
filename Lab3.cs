namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Please enter the number of elements the array should contain: ");
            int num;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid");
                Console.ResetColor();
            }
            int[] arr = new int[num];
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
                Console.Write($"Please enter element {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid");
                    Console.ResetColor();
                }
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"The largest element in the array is: {max}");
            */



            /*
            Console.Write("Please enter the number of elements the array should contain: ");
            int num;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid");
                Console.ResetColor();
            }
            int[] arr = new int[num];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
                Console.Write($"Please enter element {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid");
                    Console.ResetColor();
                }
            }
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
                if (i >= 1)
                {
                    Console.Write(',');
                }
            }
            */



            /*
            Console.Write("Please enter the number: ");
            int num;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid");
                Console.ResetColor();
            }
            if (num < 0)
            {
                Console.WriteLine("The number {0} is negative.", num);
            }
            else if (num > 0)
            {
                Console.WriteLine("The number {0} is positive.", num);
            }
            else
            {
                Console.WriteLine("The number {0} is zero.", num);
            }
            */



            /*
            Console.Write("Please enter your grade: ");
            double grade;
            while (!double.TryParse(Console.ReadLine(), out grade) || grade < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid");
                Console.ResetColor();
            }
            if (grade >= 2.00 && grade <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (grade >= 3.00 && grade <= 4.49)
            {
                Console.WriteLine("Poor");
            }
            else if (grade >= 4.50 && grade <= 5.49)
            {
                Console.WriteLine("Good");
            }
            else if (grade >= 4.00 && grade <= 5.49)
            {
                Console.WriteLine("Very Good");
            }
            else if (grade >= 5.50 && grade <= 6.00)
            {
                Console.WriteLine("Exellent");
            }
            else
            {
                Console.WriteLine("Unknow");
            }
            */



            /*
            Console.Write("Please enter number A: ");
            int a;
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Wrong syntax please enter number: ");
                Console.ResetColor();
            }
            Console.Write("Please enter number B: ");
            int b;
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Wrong syntax please enter number: ");
                Console.ResetColor();
            }
            Console.WriteLine("Press 1 to: +\nPress 2 to: -\nPress 3 to: *\nPress 4 to: /");
            int expression;
            while (!int.TryParse(Console.ReadLine(), out expression) || expression <= 0 || expression >= 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid");
                Console.ResetColor();
            }
            switch (expression)
            {
                case 1:
                    int s = sum(a, b);
                    Console.WriteLine($"{a} + {b} = {s}"); break;
                case 2:
                    s = diff(a, b);
                    Console.WriteLine($"{a} - {b} = {s}"); break;
                case 3:
                    s = mul(a, b);
                    Console.WriteLine($"{a} * {b} = {s}"); break;
                case 4:
                    s = div(a, b);
                    if (a % b != 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("{0} is not divisible by {1}", a, b);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"{a} / {b} = {s}");
                    }
                    break;
            }
            */



                /*
                int num;
                Console.WriteLine("Please enter your number: ");
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid. Please enter numebr");
                    Console.ResetColor();
                }
                Console.Clear();
                int numinverse = num-1;
                for (int i = 1; i <= num; i++)
                {
                    for (int j = 1; j <= num; j++)
                    {
                        if (j <= i)
                        {
                            Console.Write($"{j}");
                        }
                    }
                    Console.WriteLine();
                }
                for (int i = 1; i <= num; i++)
                {
                    for (int j = 1; j <= num; j++)
                    {
                        if (j <= numinverse)
                        {
                            Console.Write($"{j}");
                        }
                    }
                    numinverse--;
                    Console.WriteLine();
                }
                */
        }
        public static int sum(int x, int y)
        {
            return x + y;
        }
        public static int diff(int x, int y)
        {
            return x - y;
        }
        public static int mul(int x, int y)
        {
            return x * y;
        }
        public static int div(int x, int y)
        {
            return x / y;
        }
    }
}
