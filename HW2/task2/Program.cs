// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number / 100 > 0) {
	if (number / 1000 > 0) {
		while (number / 1000 > 0) {
			number = number / 10;
		}
	}
	int result = number % 100 % 10;
	Console.WriteLine("Третья цифра числа: " + result);
}
else {
	Console.WriteLine("У числа нет третьей цифры");
}

