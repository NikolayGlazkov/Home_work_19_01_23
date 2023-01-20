// // Найти расстояние между точками в пространстве 2D/3D


// Это задание просит найти расстояние между двумя точками в двумерном или трехмерном пространстве.

// 2D, расстояние между точками (x1, y1) и (x2, y2) можно найти с помощью формулы: √((x2-x1)² + (y2-y1)²)
// В трехмерном пространстве, расстояние между точками (x1, y1, z1) и (x2, y2, z2) можно найти с помощью формулы: √((x2-x1)² + (y2-y1)² + (z2-z1)²)
// Вам нужно будет использовать координаты точек и применить формулу для вычисления расстояния между ними. Результат можно вывести в консоль или присвоить переменной для дальнейшего использования.§§§

Console.WriteLine("Введите координату x1:");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y1:");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату x2:");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y2:");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату 12:");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Z2:");
int z2 = int.Parse(Console.ReadLine());

int exponent = 2;
int ferst = ((x1*1)-(x2*1));
int two = ((y1*1)-(y2*1));
int zed = ((z1*1)-(z2*1));


double result1 = Math.Pow(ferst, exponent);
double result2 = Math.Pow(two, exponent);
double result3 = Math.Pow(zed, exponent);

double result = Math.Sqrt(result1 + result2);
double result_z = Math.Sqrt(result1 + result2+result3);

Console.WriteLine("Растояние между 2 точками в 2D равно " + result);
Console.WriteLine("Растояние между 2 точками в 3D равно " + result_z);