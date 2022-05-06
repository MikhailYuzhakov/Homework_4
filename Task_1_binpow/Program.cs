/*
Задача 25: Напишите (функцию) цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
с помощью бинарного возведения в степень.
*/

Console.Clear();
Console.WriteLine("Введите число и степень в которую его необходимо возвести: ");
int number = Convert.ToInt32(Console.ReadLine());
int pow = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(binpow(number, pow));

int binpow (int a, int n) {
	if (n == 0)
		return 1;
	if (n % 2 == 1)
		return binpow (a, n-1) * a;
	else {
		int b = binpow (a, n/2);
		return b * b;
	}
}