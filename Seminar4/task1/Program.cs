// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма = " + GetSum(a));

int GetSum(int number) {
	int sum = 0;
	int count = 0;

	while(number>count) {
		count++;
		sum += count;

	} 
	return sum;
}