// Найти максимальное значение из 9 чисел
int Max(int arg1, int arg2, int arg3) {
	int result = arg1;
	if(arg2>result) result = arg2;
	if(arg3>result) result = arg3;
	return result;
}

int[] array = {17, 4, 32, 0, -4, 99, 3, 103, 99};

int max = Max(
					Max(array[0], array[1], array[2]),
					Max(array[3], array[4], array[5]),
					Max(array[6], array[7], array[8])
);

Console.WriteLine(max);