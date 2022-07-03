/* Задача 54. Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива. */

/* int[,] mass = new int[5, 5];
FillArray(mass);
Print(mass);

for (int i = 0; i < mass.GetLength(0); i++)
    for (int j = 0; j < mass.GetLength(1); j++)
        for (int k = 0; k < mass.GetLength(1); k++)
        {
            if (mass[i, j] <= mass[i, k]) continue;
            int temp = mass[i, j];
            mass[i, j] = mass[i, k];
            mass[i, k] = temp;
        }

System.Console.WriteLine();
Print(mass);

int[,] FillArray(int[,] array)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(mass[i, j] + "\t");
        }
        Console.WriteLine();
    }
} */


/* Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов. */

/* int[,] mass = new int[5, 5];
int sum = int.MaxValue;
int index = 0;
FillArray(mass);
Print(mass);


for (int i = 0; i < mass.GetLength(0); i++)
{
    int temp = 0;
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        temp += mass[i, j];
    }
    if (temp < sum)
    {
        sum = temp;
        index = i;
    }
}
Console.WriteLine($"Строка: {index + 1}. Сумма: {sum}");

int[,] FillArray(int[,] array)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(mass[i, j] + "\t");
        }
        Console.WriteLine();
    }
} */