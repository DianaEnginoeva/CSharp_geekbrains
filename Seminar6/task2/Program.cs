// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
// 1,2,4 - не существует

// Console.WriteLine("Введите стороны треугольника(a,b,c): ");
// double number1 = Convert.ToDouble(Console.ReadLine());
// double number2 = Convert.ToDouble(Console.ReadLine());
// double number3 = Convert.ToDouble(Console.ReadLine());

// void CheckTriangle(double a,double b,double c)
// {
//     if( a < b + c && b < c + a && c < a + b)
//     {
//         Console.WriteLine("Треугольник со сторонами такой длины может существовать.");
//     }
//     else
//     {
//         Console.WriteLine("Треугольник не существует.");
//     }
// }
// CheckTriangle(number1,number2,number3);

//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// void toBinar(int num) {
// 	string result = String.Empty;
// 	while (num>0) {
// //в строке ниже C# автоматически все num в string
// 		result = num%2+result;
// 		num /= 2;
// 	}
// 	Console.WriteLine(result);
// }
// toBinar(45);
// toBinar(46);
// toBinar(3);

//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


//массив
// void Fibonacci(int number) {
// 	if(number==0) return;
// 	if(number==1) Console.WriteLine(0);
// 		else {
// 			double[] array = new double[number];
// 			array[0]=0;
// 			array[1]=1;
// 			for(int i = 1; i < number-1; i++) {
// 				array[i+1] = array[i]+array[i-1];
// 			}
// 			for(int j=0; j<array.Length; j++) {
// 			Console.WriteLine(array[j]);
// 			}
// 		}
// }
// Fibonacci(50);

//не массив (введение числа в консоль очень тормозит (например, числа могут удваиваться))
int num = Convert.ToInt32(Console.ReadLine());

void Fibonacci(int num) {
	double num1 = 0;
	double num2 = 1;

	if(num==0) return;
	if(num==1) Console.WriteLine("Числа Фибоначчи: " + num1 + " ");
	else {
		Console.Write("Числа Фибоначчи: ");
		Console.Write(num1 + " ");
		Console.Write(num2 + " ");
		for(int i = 3; i<=num; i++) {
			double newNum = num1+num2;
			Console.Write(newNum + " ");
			num1 = num2;
			num2 = newNum;
		}
		Console.WriteLine();
	}
}
Fibonacci(num);