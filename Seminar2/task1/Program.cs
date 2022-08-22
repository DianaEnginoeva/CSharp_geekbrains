// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа

int number = new Random().Next(10, 100); //потому что нужно включая 99
int num1 = number / 10;
int num2 = number % 10;

int max = num1;
if (num2 > max) {
	max = num2;
}
Console.WriteLine("Число: " + number);
Console.WriteLine("Наибольшая цифра числа: " + max);