/*
Напишите функцию, которая принимает на вход число и выдаёт сумму цифр в числе.
*/

int number = 0, sum = 0;
int i = 0;
int lastNumber = 0;

Console.Clear();
Console.WriteLine("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());
lastNumber = number;

while (number > 0) {
    sum = sum + number % 10;
    number = number / 10;
    i++;
}

Console.WriteLine("Сумма цифр в числе " + lastNumber + " равна " + sum);