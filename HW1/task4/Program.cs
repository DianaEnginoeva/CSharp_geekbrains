﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int currentNumber = 2;

while (currentNumber<=num) {
	Console.Write(currentNumber + " ");
	currentNumber+=2;
}
	Console.WriteLine();


