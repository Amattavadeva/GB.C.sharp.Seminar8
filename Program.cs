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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            mass[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            mass[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
} */

/* Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц. */

int[,] mass1 = new int[3, 3];
int[,] mass2 = new int[3, 3];

Console.WriteLine("Первая матрица");
FillArray(mass1);
Print(mass1);
System.Console.WriteLine();
Console.WriteLine("Вторая матрица");
FillArray(mass2);
Print(mass2);

int MassRows1 = mass1.GetUpperBound(0) + 1;
int MassRows2 = mass2.GetUpperBound(0) + 1;
int MassColumns1 = mass1.GetUpperBound(1) + 1;
int MassColumns2 = mass2.GetUpperBound(1) + 1;

int[,] mass3 = new int[MassRows1, MassColumns2];

if (MassColumns1 != MassRows2)
{
    Console.WriteLine("Умножение невозможно!");
}

else
{
    for (int i = 0; i < MassRows1; i++)
    {
        for (int j = 0; j < MassColumns2; j++)
        {
            mass3[i, j] = 0;
            for (var k = 0; k < MassColumns1; k++)
            {
                mass3[i, j] += mass1[i, k] * mass2[k, j];
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine("Результат произведения");
    Print(mass3);
}



int[,] FillArray(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = new Random().Next(0, 10);
        }
    }
    return mass;
}

void Print(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write(mass[i, j] + "\t");
        }
        Console.WriteLine();
    }
}