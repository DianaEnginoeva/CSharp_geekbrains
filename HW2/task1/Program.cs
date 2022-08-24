// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int temp1 = number / 10;
int result = temp1 % 10;

Console.WriteLine("Вторая цифра числа " + number + ": " + result);
