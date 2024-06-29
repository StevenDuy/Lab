/*
Console.Write("PLease enter number of student: ");
int number;
while (!int.TryParse(Console.ReadLine(), out number))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Wrong syntax please enter number: ");
    Console.ResetColor();
}
for  (int i = 1; i <= number; i++)
{
    Console.Write($"Please enter student name {i}: ");
    string name = Console.ReadLine();
    Console.Write($"Please enter age of student {i}: ");
    int age;
    while (!int.TryParse(Console.ReadLine(), out age))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Wrong syntax please enter age: ");
        Console.ResetColor();
    }
    Console.Write($"Please enter grade of student {i}: ");
    decimal grade;
    while (!decimal.TryParse(Console.ReadLine(), out grade) || grade > 10 || grade < 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Wrong syntax please enter number (0 - 10): ");
        Console.ResetColor();
    }
    Console.Clear();
    Console.WriteLine("Name: {0}, Age: {1}, Grade: {2}", name, age, grade);
}
*/



/*
Console.Write("Please enter grade: ");
decimal grade;
while (!decimal.TryParse(Console.ReadLine(), out grade) || grade > 10 || grade < 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Wrong syntax please enter grade 0 - 10: ");
    Console.ResetColor();
}
if (grade >= 3)
{
    Console.WriteLine("Passed!");
}
else;
*/



/*
Console.Write("Please enter grade: ");
decimal grade;
while (!decimal.TryParse(Console.ReadLine(), out grade) || grade > 10 || grade < 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Wrong syntax please enter grade 0 - 10: ");
    Console.ResetColor();
}
if (grade >= 3)
{
    Console.ForegroundColor= ConsoleColor.Green;
    Console.WriteLine("Passed!");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor= ConsoleColor.Red;
    Console.WriteLine("Failed!");
    Console.ResetColor();
}
*/



/*
Console.Write("Please enter Hours: ");
int hours;
while (!int.TryParse(Console.ReadLine(), out hours) || hours > 23 || hours < 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Please enter hours 0 - 23");
}
Console.Write("Please enter minutes: ");
int minutes;
while (!int.TryParse(Console.ReadLine(), out minutes) || minutes > 60 || minutes < 0)
{
    Console.WriteLine("Please enter hours 0 - 59");
}
minutes += 30;
if (minutes > 59)
{
    minutes -= 60;
    hours++;
}
if (hours > 23)
{
    hours = 0;
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("{0}:{1}",hours, minutes);
Console.ResetColor();
*/



/*
int month;
Console.Write("Please enter number of month: ");
while (!int.TryParse(Console.ReadLine(), out month) || month > 12 || month < 1)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Error. You must choose 1-12");
    Console.ResetColor();
}
switch (month)
{
    case 1:
        Console.WriteLine("January");
        break;
    case 2:
        Console.WriteLine("February");
        break;
    case 3:
        Console.WriteLine("March");
        break;
    case 4:
        Console.WriteLine("April");
        break;
    case 5:
        Console.WriteLine("May");
        break;
    case 6:
        Console.WriteLine("June");
        break;
    case 7:
        Console.WriteLine("July");
        break;
    case 8:
        Console.WriteLine("August");
        break;
    case 9:
        Console.WriteLine("September");
        break;
    case 10:
        Console.WriteLine("October");
        break;
    case 11:
        Console.WriteLine("November ");
        break;
    case 12:
        Console.WriteLine("December");
        break;
}
*/



/*
Console.WriteLine("1. England   2. USA  3. Spain    4. Argentina    5. Mexico");
int language;
while (!int.TryParse(Console.ReadLine(), out language) || language > 5 || language < 1)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Wrong syntax. Please enter 1 - 5");
    Console.ResetColor();
}
switch (language)
{
    case 1:
    case 2:
        Console.WriteLine("English"); break;
    case 3:
        Console.WriteLine("Spainish"); break;
    case 4:
    case 5:
        Console.WriteLine("Unknown"); break;
}
*/



/*
Console.WriteLine("1. Weekday   2. Weekend  3. Holiday");
int day;
while (!int.TryParse(Console.ReadLine(), out day) || day > 3 || day < 1)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Wrong syntax. Please enter 1 - 3");
    Console.ResetColor();
}
switch (day)
{
    case 1:
        Console.Write("please enter your age: ");
        int age = int.Parse(Console.ReadLine());
        if (0 <= age && age <= 18)
        {
            Console.WriteLine("12$");
        }
        else if (age > 18 && age <= 64)
        {
            Console.WriteLine("18$");
        }
        else if (age > 64 && age <= 122)
        {
            Console.WriteLine("12$");
        }
        break;
    case 2:
        Console.Write("please enter your age: ");
        int age1 = int.Parse(Console.ReadLine());
        if (0 <= age1 && age1 <= 18)
        {
            Console.WriteLine("15$");
        }
        else if (age1 > 18 && age1 <= 64)
        {
            Console.WriteLine("20$");
        }
        else if (age1 > 64 && age1 <= 122)
        {
            Console.WriteLine("15$");
        }
        break;
    case 3:
        Console.Write("please enter your age: ");
        int age2 = int.Parse(Console.ReadLine());
        if (0 <= age2 && age2 <= 18)
        {
            Console.WriteLine("5$");
        }
        else if (age2 > 18 && age2 <= 64)
        {
            Console.WriteLine("12$");
        }
        else if (age2 > 64 && age2 <= 122)
        {
            Console.WriteLine("10$");
        }
        break;

}
*/