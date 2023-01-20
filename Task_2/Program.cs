// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("введите искомое число №1");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number №2");
int num2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(num1);

if (result == num2)
{
    Console.WriteLine($"квадратный корень Числа №1: =  {num2}");
}

if (result != num2)
{
    Console.WriteLine($"квадратный корень Числа №1:  не равен числу {num2}");
}