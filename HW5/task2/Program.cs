// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[12];
for(int i=0; i<array.Length; i++) {
	array[i]=new Random().Next(-99, 100);
}

int sumOddPositionNumb = 0;
for(int j=0; j<array.Length; j++) {
	if (j%2==1) {
		sumOddPositionNumb += array[j];
	}
}

Console.WriteLine("Массив: " + String.Join(";", array));
Console.WriteLine(sumOddPositionNumb);
