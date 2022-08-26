// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int count = 1; count<=number; count++) {
	double result = Math.Pow(count, 3);
	Console.WriteLine(result);
}
