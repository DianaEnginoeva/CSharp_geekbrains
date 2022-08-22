// Найти индекс элемента массива равный find
int[] array = {17, 4, 32, 0, -4, 99, 3, 103, 99};

int n = array.Length;
int find = 4;

int index = 0;

while (index < n) {
	if(array[index] == find)
	{
		Console.WriteLine(index);
		break;
	}
	index++;
}