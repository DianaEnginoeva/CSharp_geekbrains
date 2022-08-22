// заполняем массив
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

// Найти индекс элемента массива равный find
int IndexOf(int[] collection, int find) {
	int count = collection.Length;
	int index = 0;
	int position = -1;

	while (index<count) {
		if(collection[index] == find) {
			position = index;
			break;
		}
		index++;

	}
	return position;
}

// объявляем массив
int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

Console.WriteLine(IndexOf(array, 4));
