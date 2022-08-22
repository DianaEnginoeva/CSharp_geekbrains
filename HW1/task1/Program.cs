// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.Write("Введите первое число: ");
int numFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numSecond = Convert.ToInt32(Console.ReadLine());

if(numFirst > numSecond) {
	Console.Write("Максимальное число: ");
	Console.WriteLine(numFirst);
}
else {
	Console.Write("Максимальное число: ");
	Console.WriteLine(numSecond);
}