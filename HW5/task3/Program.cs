// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] array = {9, 8, 6, 5.5, 9.32, 3, 2, 1.75};

double maxNumber = array[0];
double minNumber = array[0];

for(int i=0; i<array.Length; i++) {
	if (maxNumber<array[i]) {
		maxNumber = array[i];
	}
	if (minNumber>array[i]) {
		minNumber = array[i];
	}
}
double result = maxNumber - minNumber;

Console.WriteLine("Максимальное " + maxNumber);
Console.WriteLine("Минимальное " + minNumber);
Console.WriteLine("Разница " + result);

