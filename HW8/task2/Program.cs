// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Первоначальный массив:");
int[,] array = new int[new Random().Next(3, 7), new Random().Next(2, 7)];
//тестовый массив
// int[,] array = new int[4, 3] {{3, 0, 0}, {4, 1, 2}, {9, 4, 2}, {4, 5, 9}};

int[] sum = new int[array.GetLength(0)];
int minSum = int.MaxValue;
int minSumPosition = 0;

for(int i=0; i<array.GetLength(0); i++)
{
	for(int j=0; j<array.GetLength(1); j++)
	{
		array[i, j] = new Random().Next(0, 10);
		Console.Write(array[i, j] + "\t");
		sum[i] += array[i, j];
	}
	if (sum[i]<minSum)
	{
		minSum = sum[i];
		minSumPosition = i;
	}
	Console.WriteLine();
}
Console.WriteLine("Минимальная сумма: " + minSum);
Console.WriteLine("Номер строки с минимальной суммой: " + minSumPosition);
