// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
int positiveNumbersAmount = 0;
for (int i=0; i<length; i++)
{
	Console.WriteLine("Введите значение элемента массива: ");
	array[i]=Convert.ToInt32(Console.ReadLine());
	if (array[i]>0) positiveNumbersAmount++;
}

Console.WriteLine("Количество чисел больше нуля: " + positiveNumbersAmount);
