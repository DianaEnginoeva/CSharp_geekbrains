// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int randomLenght = new Random().Next(2, 21);

int[] array = new int[randomLenght];
for(int i = 0; i<array.Length; i++) {
	array[i]=new Random().Next(100, 1000);
}

int GetEvenNumsAmount(int[] array) {
	int count = 0;
	for(int j=0; j<array.Length; j++) {
		if (array[j]%2 == 0) {
			count++;
		}
	}
	return count;
}

Console.WriteLine("Массив: " + String.Join(";", array));
int result = GetEvenNumsAmount(array);
Console.WriteLine(result);
