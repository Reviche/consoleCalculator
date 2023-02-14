namespace consoleCalculator

{
class Calculator
{
    static void Main(string[] args)
    {
do{
double num1 = 0;
double num2 = 0;
double result = 0;

Console.WriteLine("Console Calculator!!!");


Console.Write("Enter number 1: ");
num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter number 2: ");
num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter an option ");
Console.WriteLine("Add: + ");
Console.WriteLine("Subtract: -");
Console.WriteLine("Multiply: * ");
Console.WriteLine("Divide: /");
Console.Write("Enter an Option: ");

switch (Console.ReadLine())
{
    case "+":
        result = num1 + num2;
        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
        break;

    case "-":
        result = num1 - num2;
        Console.WriteLine($"Your result: {num1} - {num2} = " + result);
        break;
    case "*":
        result = num1 * num2;
        Console.WriteLine($"Your result: {num1} * {num2} = " + result);
         break;
    case "/":
        result = num1 / num2;
        Console.WriteLine($"Your result: {num1} / {num2} = " + result);
        break;

default:
Console.WriteLine("That was not an option");
    break;

    }
Console.Write("Continue? y/n: ");
} while (Console.ReadLine().ToLower() == "y");

Console.WriteLine("Okay Bye!");





        }

    }    

}
