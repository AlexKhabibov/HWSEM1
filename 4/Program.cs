// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Input first number");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input third number");
int number3 = Convert.ToInt32(Console.ReadLine());

int maxNumber = number1;

if (number2 > number1) maxNumber = number2;
if (number3 > number2) maxNumber = number3;
Console.WriteLine("max number is " + maxNumber);