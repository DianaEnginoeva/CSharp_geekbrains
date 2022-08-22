﻿// заполняем массив
void FillArray(int[] collection) {
	int length = collection.Length;
	int index = 0;
	while (index < length) {
		collection[index] = new Random().Next(1, 10);
		index++;
	}
}

// выводим массив
void PrintArray(int[] col) {
	int count = col.Length;
	int position = 0;
	while (position < count) {
		Console.WriteLine(col[position]);
		position++;
	}
}

// объявляем массив
int[] array = new int[10];

FillArray(array);
PrintArray(array);