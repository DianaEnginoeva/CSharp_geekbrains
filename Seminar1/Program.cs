// Задание 1. Находим квадрат введенного числа
// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// int sqr = number * number;

// Console.WriteLine(sqr);

// Задание 2. Вводим два числа. Проверяем, является ли первое число квадратом второго
// Console.WriteLine("Введите первое число:");
// int numFirst = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int numSecond = Convert.ToInt32(Console.ReadLine());
// if(numFirst == (numSecond * numSecond)) {
// 	Console.WriteLine("Да. Первое число является квадратом второго");
// }
// else {
// 	Console.WriteLine("Нет. Первое число не является квадратом второго");
// }

// Задание 3. Вводим и число и получаем соответствующий ему день недели
// string day = "Понедельник";
// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number == 1) day = "Понедельник";
// if (number == 2) day = "Вторник";
// if (number == 3) day = "Среда";
// if (number == 4) day = "Четверг";
// if (number == 5) day = "Пятница";
// if (number == 6) day = "Суббота";
// if (number == 7) day = "Воскресенье";
// if (number < 1 || number > 7) day = "Число введено неверно";
// // else { day = "Число введено неверно"; } - почему это не работает?

// Console.WriteLine(day);

// Задание 4. Вводим число N. Выводим все целые числа от -N до N
// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// int currentNumber = number * (-1);
// while (currentNumber <= number) {
// 	Console.Write(currentNumber);
// 	Console.Write(" ");
// 	currentNumber++;
// }

// Задание 5. Вводим трехзначное число - выводим его последнюю цифру
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
while (number>10) {
	number = number % 10;
}
Console.WriteLine(number);