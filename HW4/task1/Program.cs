// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

double GetNumberInPower(int number, int power)
{
	double result = Math.Pow(number, power);
	return result;
}

double numberForPrint = GetNumberInPower(3, 5);
Console.WriteLine(numberForPrint);
