// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)
// Console.WriteLine("Введите номер четверти: ");
// int part = Convert.ToInt32(Console.ReadLine());

// if (part == 1) {
// 	Console.WriteLine("x = [0; +бесконечность]; y = [0; +бесконечность]");
// }
// else if (part == 2) {
// 	Console.WriteLine("x = [0; -бесконечность]; y = [0; +бесконечность]");
// }
// else if (part == 3) {
// 	Console.WriteLine("x = [0; -бесконечность]; y = [0; -бесконечность]");
// }
// else if (part == 4) {
// 	Console.WriteLine("x = [0; +бесконечность]; y = [0; -бесконечность]");
// }
// else {
// 	Console.WriteLine("Введено неверное значение");
// }


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
// Console.WriteLine("Введите x первой точки: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y первой точки: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите x второй точки: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y второй точки: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double x = Math.Pow(x2-x1, 2);
// double y = Math.Pow(y2-y1, 2);

// double result = Math.Sqrt(x + y);

// // то же самое в одну строку
// // double result = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));

// Console.WriteLine(result);

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
// while (count<=number) {
// 	double result = Math.Pow(count, 2);
// 	Console.WriteLine(result);
// 	count++;
// }

for (int count = 1; count<=number; count++) {
	double result = Math.Pow(count, 2);
	Console.WriteLine(result);
}