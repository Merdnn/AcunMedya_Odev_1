// 1 - Sayının Pozitif, Negatif veya Sıfır Olduğunu Belirleme
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
    Console.WriteLine("Pozitive");
else if (number < 0)
    Console.WriteLine("Negative");
else
    Console.WriteLine("Zero");

// 2 - Gün İsmi Belirleme 
Console.Write("Enter a number between 1-7: ");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1: Console.WriteLine("Monday"); break;
    case 2: Console.WriteLine("Tuesday"); break;
    case 3: Console.WriteLine("Wednesday"); break;
    case 4: Console.WriteLine("Thursday"); break;
    case 5: Console.WriteLine("Friday"); break;
    case 6: Console.WriteLine("Saturday"); break;
    case 7: Console.WriteLine("Sunday"); break;
    default: Console.WriteLine("Invalid input"); break;
}

// 3 - Simple Calculator
Console.Write("Enter the first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Choose an operation (+, -, *, /) :");
char operation = Convert.ToChar(Console.ReadLine());

switch (operation)
{
    case '+': Console.WriteLine($"Result: {num1 + num2}"); break;
    case '-': Console.WriteLine($"Result: {num1 - num2}"); break;
    case '*': Console.WriteLine($"Result: {num1 * num2}"); break;
    case '/': Console.WriteLine(num2 != 0 ? $"Result: {num1 / num2}" : "Division error!"); break;
    default: Console.WriteLine("Invalid operation"); break;
}

// 4 - Find the Largest of Three Numbers
Console.Write("Enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the third number: ");
int c = Convert.ToInt32(Console.ReadLine());

int largest = (a > b) ? ((a > c) ? a : c) : ((b > c) ? b : c);
Console.WriteLine($"Largest number: {largest}");

// 5 - Check Password Strength
Console.Write("Enter a password: ");
string password = Console.ReadLine();
if (password.Length >= 8 &&
    password.IndexOfAny(new char[] { '@', '#', '$', '%' }) != -1 &&
    password.Any(char.IsUpper))
{
    Console.WriteLine("Strong password!");
}
else
{
    Console.WriteLine("Weak password! Please enter a password meets the criteria.");
}

