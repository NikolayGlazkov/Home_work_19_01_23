//  Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Write("введите число ");
int num1 = int.Parse(Console.ReadLine());

if (num1 <= 5 )
{
    Console.WriteLine($"Будний день");
}
if (6 <= num1 && num1 <= 7)
{
    Console.WriteLine($"выходной");
}
if (num1 > 7)
{
    Console.WriteLine($"нельзя использовать числа больше 7");
}