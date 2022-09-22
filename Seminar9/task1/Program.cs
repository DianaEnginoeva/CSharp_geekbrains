// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
//N=5 => "1, 2, 3, 4, 5"

// string Numbers(int n)
// {
// 	if (n==1) return $"{n}";
// 	else return (Numbers(n-1)) + $" {n}";
// }

// Console.WriteLine(Numbers(7));

// Задайте значение M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M=4, N=9 => "4, 5, 6, 7, 8, 9"

// string Numbers(int m, int n)
// {
// 	if (m>n) return string.Empty;
// 	else return $"{m} " + Numbers(m+1, n);
// }

// Console.WriteLine(Numbers(3, 7));

// //Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// int SumNumber(int n)
// {
// 	if(n == 0) return 0;
// 	return (n % 10 + SumNumber(n/10));
// }

// Console.WriteLine(SumNumber(number));

//Напишите программу, которая на вход принимает два числа A и B и возводит число A в степень B

Console.WriteLine("Введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());

int numberExponentiation(int a, int b)
{
	if(b == 0) return 1;
	else return numberExponentiation(a, b-1) * a;
}

Console.WriteLine("Число A в степени B: " + numberExponentiation(numberA, numberB));
