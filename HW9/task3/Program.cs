// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());

int functionAckermann(int m, int n)
{
	if (m == 0) return (n + 1);
	if (n == 0) return functionAckermann(m - 1, 1);
	return functionAckermann(m - 1, functionAckermann(m, n - 1));
}

Console.WriteLine(functionAckermann(numberM, numberN));


