// вычисление факториала

// int Factorial(int n) {
// 	if(n==1) return 1;
// 	else return n*Factorial(n-1);
// } 

// Console.WriteLine(Factorial(5)); //все работает хорошо
// Console.WriteLine(Factorial(17)); // получаем отрицательное число, потому что тип int переполнен; чтобы этого не происходило - воспользуемся типом double в качестве возвращаемого ниже

// вычисление факториала

double Factorial(int n) {
	if(n==1) return 1;
	else return n*Factorial(n-1);
} 

Console.WriteLine(Factorial(5)); //все работает хорошо
Console.WriteLine(Factorial(17)); //все окей