// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetSum(int number) {
	int sum = 0;
	for(int i=0; i<number; i++)
	{
		sum += number % 10;
		number /= 10;
	}
	return sum;
}

int result = GetSum(9012);
Console.WriteLine(result);
