// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Первоначальный массив:");
int[,] array = new int[new Random().Next(3, 7), new Random().Next(2, 7)];
//тестовый массив
// int[,] array = new int[2, 3] {{5, 6, 2}, {4, 5, 1}};

for(int i=0; i<array.GetLength(0); i++)
{
	for(int j=0; j<array.GetLength(1); j++)
	{
		array[i, j] = new Random().Next(0, 10);
		Console.Write(array[i, j] + "\t");
		
	}
	Console.WriteLine();
}

Console.WriteLine("Новый массив:");
int[,] newArray = array;

for(int i=0; i<newArray.GetLength(0); i++)
{
	int temp = 0;
	for(int j=0; j<newArray.GetLength(1); j++)
	{
		for (int k = j+1; k < array.GetLength(1); k++)
    {
				if(array[i,k] > array[i,j])
				{
					temp = array[i,k];
					array[i,k] = array[i,j];
					array[i,j] = temp;
				}
		}
		Console.Write(newArray[i, j] + "\t");
	}
	Console.WriteLine();
}


