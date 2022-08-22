// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
Console.Write("Введите первое число: ");
int numFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numSecond = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int numThird = Convert.ToInt32(Console.ReadLine());

int max = numFirst;

if (numSecond > max) max = numSecond;
if (numThird > max) max = numThird;

Console.Write("Максимальное число: ");
Console.WriteLine(max);