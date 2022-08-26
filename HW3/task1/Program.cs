// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.WriteLine("Введите число: ");
string? number = Console.ReadLine();
int length = number.Length;
string number2 = "";

for (int i=length-1; i>=0; i--) {
	 number2 += number[i];
}
if (number==number2) {
	Console.WriteLine("Число " + number + " является палиндромом");
}
else {
	Console.WriteLine("Число " + number + " не является палиндромом");
}
