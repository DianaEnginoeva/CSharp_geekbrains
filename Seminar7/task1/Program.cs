//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

Console.WriteLine("Введите количество строк: ");
var num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
var num2 = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[num1, num2];

for(int i=0; i<num1; i++) 
{
	for(int j=0; j<num2; j++)
	{
		array[i, j] = new Random().Next(1, 100);
		Console.Write(array[i,j] + " ");
	}
	Console.WriteLine();
}

Console.WriteLine(String.Join(';', array));


