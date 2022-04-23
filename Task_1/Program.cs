/*
Задача 25: Напишите (функцию) цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
*/

Console.Clear();
Console.WriteLine("Введите число и степень в которую его необходимо возвести: ");
int number = Convert.ToInt32(Console.ReadLine());
int pow = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(number + " в " + pow + " степени = " + userPow(number, pow));

static int userPow(int numb, int deg) {
    int res = 1;
    for (int i = 1; i <= deg; i++) {
        res = res * numb;
    }
    return res;
}
