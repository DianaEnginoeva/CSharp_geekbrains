


//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] array = new int[8];
// for(int i = 0; i<array.Length; i++) {
// 	array[i] = new Random().Next(-9, 10);
// }
// Console.WriteLine("Первоначальный массив: " + String.Join(";", array));
// for(int j=0; j<array.Length; j++) {
// 	array[j]=array[j]*(-1);
// }
// Console.WriteLine("Измененный массив: " + String.Join(";", array));

//такой же, но короче
// int [] array= {-4, -8, 8, 2};
// for(int i=0; i < array.Length; i++)
// {
// 	array[i]*=-1;
// }

// Console.WriteLine("[{0}]", String.Join(",", array));

//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// int [] array= {-4, 6, 0, 12, -8, -5, 1, 8, 2};
// int number = new Random().Next(-9, 10);
// int count=0;
// Console.WriteLine(number);

// for(int i = 0; i<array.Length; i++) {
// 	if(array[i]==number) {
// 		count++;
// 	}
// }

// if(count>0) {
// 		Console.WriteLine("да");
// }
// else {
// 		Console.WriteLine("нет");
// }

//Хорошее решении (задачи выше) Дарьи Смирновой
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
string result = "нет";
int [] array= {6, 7, 19, 345, 3, 3};
for(int i=0; i < array.Length; i++)
{
	if(array[i]== num)
	{
		result = "да";
	}
	
}
Console.WriteLine(result);