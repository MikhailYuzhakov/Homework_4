/*
Напишите программу, которая задаёт массив из некоторого количества элементов и выводит их на экран с помощью функций.
*/

int count = 0, max = 0, min = 0;
int i = 0;
int[] array = new int[1000];
Random rnd = new Random();

Console.Clear();
Console.WriteLine("Введите количество элементов в массиве: ");
count = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите верхний и нижний пределы генерации значений элементов массива в произвольном порядке: ");
max = Convert.ToInt32(Console.ReadLine());
min = Convert.ToInt32(Console.ReadLine());

if (min > max) {
    i = max;
    max = min;
    min = i;
}
i = 0;

Console.Clear();
Console.WriteLine("Сгенерированный массив: ");
genArray(count, min, max);

//------------------------------------------------------------------------
void genArray(int N, int minimum, int maximum) { 
    for (i = 0; i <= N; i++) {
        array[i] = rnd.Next(minimum, maximum);
        Console.Write(array[i] + " ");
    }
}
Console.WriteLine();