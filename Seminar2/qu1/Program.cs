// Задание 3. Вводим и число и получаем соответствующий ему день недели
string day = "Понедельник";
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1) day = "Понедельник";
else if (number == 2) day = "Вторник";
else if (number == 3) day = "Среда";
else if (number == 4) day = "Четверг";
else if (number == 5) day = "Пятница";
else if (number == 6) day = "Суббота";
else if (number == 7) day = "Воскресенье";
else day = "Число введено неверно";
// if (number < 1 || number > 7) day = "Число введено неверно";
// else { day = "Число введено неверно"; }
// почему это не работает? Потому что у каждого условия должно было быть "else if", иначе твое else относится только к последнему условию (==7)

Console.WriteLine(day);