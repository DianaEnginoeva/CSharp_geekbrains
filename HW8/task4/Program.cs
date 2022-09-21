// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
int count = 0;
//создаем массив с длиной 90 (т.к. двухзначных числел - 90)
int[] doubleDigits = new int[90];
//задаем элементам массива значения от 10 до 99
for(int m=0; m<doubleDigits.Length-1; m++)
{
	doubleDigits[m]=10+m;
}
//перемешиваем массив
for(int m=0; m<doubleDigits.Length; m++)
{
	int l = new Random().Next(doubleDigits.Length);
   int temp = doubleDigits[l];
   doubleDigits[l] = doubleDigits[m];
   doubleDigits[m] = temp;
}


int[,,] array = new int[2, 2, 2];

for(int i=0; i<array.GetLength(0); i++)
{
	for(int j=0; j<array.GetLength(1); j++)
	{
		for (int k = 0; k < array.GetLength(2); k++)
		{
			//задаем значения элементам массива из массива двухзначных чисел по порядку
			array[i, j, k] = doubleDigits[count];
			Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
			count++;
		}
		Console.WriteLine();
	}
}
