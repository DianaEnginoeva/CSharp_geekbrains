// Виды методов

// Вид 1. Ничего не принимают, ничего не возвращают
// void Method1() 
// {
// 	Console.WriteLine("Автор...");
// }
// Method1();

// Вид 2. Что-то принимают, ничего не возвращают
// void Method2(string msg) 
// {
// 	Console.WriteLine(msg);
// }
// Method2("Текст сообщения");

//еще одна разновидность с именованными аргументами (явно указанно какому агрументу какое значение мы хотим указать)
// void Method21(string msg, int count) 
// {
// 	int i = 0;
// 	while(i<count) {
// 		Console.WriteLine(msg);
// 		i++;
// 	}
// }
// // Method21("Текст сообщения", 4);
// Method21(count: 5, msg: "Текст сообщения");

// Вид 3. Ничего не принимают, что-то возвращают
// данная функция возвращает текущий год
// int Method3() 
// {
// 	return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

// Вид 4. Что-то принимают, что-то возвращают
// данная функция возвращает текущий год
// string Method4(int count, string text) 
// {
// 	int i = 0;
// 	string result = String.Empty;
// 	while(i<count) {
// 		result = result + text; 
// 		i++;
// 	}
// 	return result;
// }
// string res = Method4(10, "di");
// Console.WriteLine(res);

//тот же метод с помощью цикла for
// string Method4(int count, string text) 
// {
// 	string result = String.Empty;
// 	for(int i = 0; i<count; i++) {
// 		result = result + text; 
// 	}
// 	return result;
// }
// string res = Method4(10, "di");
// Console.WriteLine(res);

//вывод таблицы умножения

for(int i = 2; i<=10; i++) {
	for(int j = 2; j<=10; j++) {
		Console.WriteLine($"{i} * {j} = {i*j}");
	}
	Console.WriteLine();
}