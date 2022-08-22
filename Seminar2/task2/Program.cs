// // Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа
// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);

// int num1 = number / 100;
// int num3 = number % 10;

// Console.WriteLine(num1*10+num3);

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// Console.WriteLine("Введите число 1: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// int result = number2 % number1;
// if (result == 0) {
// 	Console.WriteLine("Число кратно.");
// }
// else {
//  Console.WriteLine("Остаток от деления: " + result);
// }

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 7 == 0 && number % 23 == 0) {
// 	Console.WriteLine(number + " да");
// }
// else {
// 	Console.WriteLine(number + " нет");
// }

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого

Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2*number2) {
	Console.WriteLine("Число 1 является квадратом числа 2");
}
else if (number2 == number1*number1) {
	Console.WriteLine("Число 2 является квадратом числа 1");
}
else {
	Console.WriteLine("Числа не являются квадратами друг друга");
}
