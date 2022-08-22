// Задание 3. Вводим и число и получаем соответствующий ему день недели
string day = "Понедельник";
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1) day = "Понедельник";
if (number == 2) day = "Вторник";
if (number == 3) day = "Среда";
if (number == 4) day = "Четверг";
if (number == 5) day = "Пятница";
if (number == 6) day = "Суббота";
if (number == 7) day = "Воскресенье";
if (number < 1 || number > 7) day = "Число введено неверно";
// else { day = "Число введено неверно"; }
// почему это не работает?

Console.WriteLine(day);