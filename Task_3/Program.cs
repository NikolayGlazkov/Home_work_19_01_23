// Этот код запрашивает у пользователя номер четверти (1, 2, 3 или 4) и выводит диапазоны возможных координат для каждой четверти.

// 1-я четверть: Х и Y оба положительные
// 2-я четверть: X отрицательный, Y положительный
// 3-я четверть: X и Y оба отрицательные
// 4-я четверть: X положительный, Y отрицательный

// Код использует if-else конструкции для проверки номера четверти, введенного пользователем, и вывода соответствующего диапазона координат.

// Если пользователь вводит некорректное число, то код выводит сообщение об ошибке.

Console.WriteLine("Enter number one of 4 quarter");
int num = int.Parse(Console.ReadLine());

if (num == 1)
{
    Console.WriteLine("Х и Y оба положительные");
}

if (num == 2)
{
    Console.WriteLine("X отрицательный, Y положительный");
}

if (num == 3)
{
    Console.WriteLine("X и Y оба отрицательные");

}

if (num == 4)
{
    Console.WriteLine("X положительный, Y отрицательный");
}
else
{
    Console.WriteLine("Эти числа не входят в 4 четверти");
}