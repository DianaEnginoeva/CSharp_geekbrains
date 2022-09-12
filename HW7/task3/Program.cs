// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// тестовый массив
// int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

int[,] array = new int[new Random().Next(1, 10), new Random().Next(1, 10)];

for(int i=0; i<array.GetLength(0); i++)
{
	for(int j=0; j<array.GetLength(1); j++)
	{
		array[i, j] = new Random().Next(0, 10);
		Console.Write(array[i, j] + "\t");
		
	}
	Console.WriteLine();
}

Console.Write("Среднее арифметическое каждого столбца: ");
double sum = 0;
int count = array.GetLength(0);
double average = 0;
for(int k=0; k<array.GetLength(1); k++)
{
	for(int m=0; m<array.GetLength(0); m++)
	{
		sum+=array[m, k];
	}
	average = Math.Round((sum/count), 2);
	Console.Write(average + "\t");
	sum = 0;
}
Console.WriteLine();
