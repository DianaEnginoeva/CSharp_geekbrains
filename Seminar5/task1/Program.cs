﻿// ДЗ, решение проблемы
// int num = 6529;
// string resalt=Convert.ToString(num);

// int sum =(int) char.GetNumericValue(resalt[0]);
// Console.WriteLine(sum);

//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
// int positiveNumbers = 0;
// int negativeNumbers = 0;

// int[] array = new int[12];
// for(int i = 0; i<array.Length; i++) {
// 	array[i] = new Random().Next(-9, 10);
// }

// for(int j = 0; j<array.Length; j++) {
// 	if(array[j]<0) {
// 		negativeNumbers+=array[j];
// 	}
// 	if(array[j]>0) {
// 		positiveNumbers+=array[j];
// 	}
// }

// // короткий способ вывести массив (без цикла)
// Console.WriteLine("Массив: " + String.Join(";", array));
// // Console.Write("Массив: ");
// // for(int count = 0; count<array.Length; count++)
// // 	{
// // 		Console.Write(array[count] + " ");
// // 	}
// // 	Console.WriteLine();

// Console.WriteLine("Сумма положительных: " + positiveNumbers);
// Console.WriteLine("Сумма отрицательных: " + negativeNumbers);

// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] inputArray = {1, 2, 3, 4, 5};
int length = inputArray.Length;
int count = 1;
int multi;

int[] outputArray = new int[length/2+length%2];
for(int i = 0; i<length; i++) {
	if(i==length-1-i) {
		outputArray[i]=inputArray[i];
	}
	else {
		multi = inputArray[i]*inputArray[length-1-i];
		outputArray[i]=multi;
	}
}
Console.WriteLine("Массив: " + String.Join(";", outputArray));

//Работающее решение
// int [] inputArray= {1,2,3,4,5};
// int [] resultArray=new int[inputArray.Length/2 + inputArray.Length%2];

// for(int i=0;i<resultArray.Length;i++)
// {
//     resultArray[i]= inputArray[i]*inputArray[inputArray.Length-1-i];

//     if(i==(inputArray.Length-1-i))
//     {
//         resultArray[i]=inputArray[i];
//     }
// }
// Console.WriteLine(String.Join(",",resultArray));