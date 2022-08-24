// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 6 || number == 7) {
	Console.WriteLine("Это выходной день");
}
else if (number >= 1 && number < 7) {
	Console.WriteLine("Это рабочий день");
}


