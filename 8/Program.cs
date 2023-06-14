// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());

int count = number * 0 + 2;

while (count <= number)
{
    Console.WriteLine(count);
    count = count + 2;
}