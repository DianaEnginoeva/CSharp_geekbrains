﻿// решение задач

// Задача2. Упорядочить массив. Сортировка методом выбора
int[] array = {8, 4, 2, 3, 4, 7, 1, 2};

void PrintArray(int[] array)
{
	int count = array.Length;

	for(int i=0; i<count; i++)
	{
		Console.Write(array[i] + " ");
	}
	Console.WriteLine();
}

void SelectionSort(int[] array)
{
	for(int i=0; i<array.Length-1; i++)
	{
		int minPosition = i;

		for(int j=i+1; j<array.Length; j++)
		{
			if(array[j]<array[minPosition]) minPosition = j;
		}

		int temp = array[i];
		array[i]=array[minPosition];
		array[minPosition] = temp;
	}

}

PrintArray(array);
SelectionSort(array);

PrintArray(array);
