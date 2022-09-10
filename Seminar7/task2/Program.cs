//Самостоятельные задачи

//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows,columns];

// for(int i=0; i<rows; i++)
// {
// 	for(int j=0; j<columns; j++)
// 	{
// 		array[i,j]=i+j;
// 		Console.Write(array[i,j] + "\t");

// 	}
// 	Console.WriteLine();
// }

//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// double[,] array = new double[rows,columns];

// Console.WriteLine("Первоначальный массив:");
// for(int i=0; i<rows; i++)
// {
// 	for(int j=0; j<columns; j++)
// 	{
// 		array[i, j] = new Random().Next(1, 100);
// 		Console.Write(array[i,j] + "\t");
// 	}
// 	Console.WriteLine();
	
// }
// Console.WriteLine();

// Console.WriteLine("Измененный массив:");
// for(int i=0; i<rows; i++)
// {
// 	for(int j=0; j<columns; j++)
// 	{
// 		if(i%2==0 && j%2==0)
// 		{
// 			array[i,j]=Math.Pow(array[i,j], 2);
// 		}
// 		Console.Write(array[i,j] + "\t");
// 	}
// 	Console.WriteLine();
// }

//Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int sum = 0;

double[,] array = new double[rows,columns];

Console.WriteLine("Массив:");
for(int i=0; i<rows; i++)
{
	for(int j=0; j<columns; j++)
	{
		array[i, j] = new Random().Next(1, 100);
		Console.Write(array[i,j] + "\t");
		if(i==j)
		{
			sum+=Convert.ToInt32(array[i, j]);
		}
	}
	Console.WriteLine();
	
}
Console.WriteLine("Сумма элементов: " + sum);

