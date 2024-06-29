/*
Console.Write("Please enter number: ");
int num;
int sum = 0;
while(!int.TryParse(Console.ReadLine(), out num) || num < 1 || num > 100)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Wrong syntax please enter your 1 - 100 again: ");
    Console.ResetColor();
}
for (int i = 1; i <= 100; i++)
{
    if (i % 2 != 0)
    {
        num--;
        sum += i;
        Console.WriteLine(i);
        if (num == 0)
        {
            break;
        }
    }
}
Console.WriteLine($"Total: {sum}");
*/



/*
Console.Write("Please enter the nummber: ");
int num;
int result;
while (!int.TryParse(Console.ReadLine(), out num))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Wrong syntax. Please enter number: ");
    Console.ResetColor();
}
for (int i = 1; i <= 10; i++)
{
    result = num * i;
    Thread.Sleep(500);
    Console.WriteLine("{0} X {1} = {2}", num, i, result);
}
*/



/*
int num1;
int num2;
int result;
Console.Write("Please enter number 1: ");
while(!int.TryParse(Console.ReadLine(), out num1))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Invalid. Please enter number: ");
    Console.ResetColor();
}
Console.Write("Please enter number 2 to product: ");
while(!int.TryParse(Console.ReadLine(),out num2))
{
    Console.ForegroundColor= ConsoleColor.Red;
    Console.Write("Invalid. Please enter number: ");
    Console.ResetColor();
}
for( int i = num2; i <= 10;  i++)
{
    result = num1 * i;
    Console.WriteLine("{0} X {1} = {2}", num1, i, result);
}
*/



/*
int evenNum;
Console.Write("Please enter even number: ");
while (!int.TryParse(Console.ReadLine(), out evenNum) || evenNum % 2 != 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Please write an even number: ");
    Console.ResetColor();
}
Console.WriteLine("The number is: {0}", Math.Abs(evenNum));
*/



/*
int number;
Console.Write("Please enter the number: ");
while (!int.TryParse(Console.ReadLine(), out number))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Please enter number: ");
    Console.ResetColor();
}
for (int i = 1; i <= number; i++)
{
    for (int j = 1; j <= number; j++)
    {
        if (j > i)
        {
            Console.Write(" ");
        }
        else
        {
            Console.Write("*");
        }
    }
    Console.WriteLine();
}
*/



/*
int number;
Console.Write("Please enter the number: ");
while (!int.TryParse(Console.ReadLine(), out number))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Please enter number: ");
    Console.ResetColor();
}
for (int i = 1; i <= number; i++) //lặp lần 1
{
    for (int j = 1; j <= number; j++) // vì j <= number => lặp đến số number
    {
        if (j <= i) // lần 1 j < i => j write 0. lần 2 j = 2 i = 1 => write 1...
        {
            Console.Write($"{j}");
        }
    }
    Console.WriteLine(); // cbị lặp dòng tiếp theo
}
*/