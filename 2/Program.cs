// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Input first number");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("First number is max. Second number is min");
}
else
{
    Console.WriteLine("First number is min. Second number is max");
}