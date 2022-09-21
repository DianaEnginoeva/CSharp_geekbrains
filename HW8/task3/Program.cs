// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Первая матрица:");
// int[,] arrayOne = new int[new Random().Next(3, 7), new Random().Next(2, 7)];
//тестовый массив
int[,] arrayOne = new int[2, 3] {{5, 6, 2}, {4, 5, 1}};
// int[,] arrayOne = new int[,] {{3, 4}, {3, 3}};

for(int i=0; i<arrayOne.GetLength(0); i++)
{
	for(int j=0; j<arrayOne.GetLength(1); j++)
	{
		// arrayOne[i, j] = new Random().Next(0, 10);
		Console.Write(arrayOne[i, j] + "\t");
		
	}
	Console.WriteLine();
}

Console.WriteLine("Вторая матрица:");
// int[,] arrayTwo = new int[new Random().Next(3, 7), new Random().Next(2, 7)];
//тестовый массив
int[,] arrayTwo = new int[3, 3] {{5, 6, 2}, {4, 5, 1}, {2, 4, 10}};
// int[,] arrayTwo = new int[,] {{2, 4}, {3, 2}};

for(int i=0; i<arrayTwo.GetLength(0); i++)
{
	for(int j=0; j<arrayTwo.GetLength(1); j++)
	{
		// arrayTwo[i, j] = new Random().Next(0, 10);
		Console.Write(arrayTwo[i, j] + "\t");
		
	}
	Console.WriteLine();
}

if (arrayOne.GetLength(1) == arrayTwo.GetLength(0))
{
	Console.WriteLine("Сумма матриц:");

	int[,] arraySum = new int[arrayOne.GetLength(0), arrayTwo.GetLength(1)];

	for (int i = 0; i<arraySum.GetLength(0); i++)
	{
		for(int j = 0; j<arraySum.GetLength(1); j++)
		{
			arraySum[i,j] = 0;
			for (int k=0; k<arrayOne.GetLength(1); k++)
			{
				arraySum[i,j]+=arrayOne[i, k] * arrayTwo[k, j];
			}
			Console.Write(arraySum[i, j] + "\t");
		}
		Console.WriteLine();
	}
}
else
{
	Console.WriteLine("Невозможно умножить матрицы");
}
