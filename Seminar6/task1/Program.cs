// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// создаем массив
int[] GetArray(int size, int min, int max) {
	int[] res = new int[size];
	for(int i=0; i<size; i++) {
		res[i] = new Random().Next(min, max+1);
	}
	return res;
}

// меняем местами элементы массива
void Reverse(int[] array) {
	for(int i=0; i<array.Length/2; i++) {
		int temp = array[i];
		array[i] = array[array.Length-1-i];
		array[array.Length-1-i] = temp;
	}
	// Console.WriteLine("Новый массив: " + String.Join(';', array));
}

int[] currentArray = GetArray(12, 1, 100);
Console.WriteLine("Первоначальный массив: " + String.Join(';', currentArray));
Reverse(currentArray);
Console.WriteLine("Новый массив: " + String.Join(';', currentArray));

