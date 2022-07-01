/* Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива. */

int[,] mass = new int[5, 5];
var max = mass[0, 0];
FillArray(mass);
Print(mass);


for (var i = 0; i < mass.GetLength(0); i++)
    for (var j = 0; j < mass.GetLength(1); j++)
        for (var k = 0; k < mass.GetLength(1); k++)
        {
            if (mass[i, j] <= mass[i, k]) continue;
            var temp = mass[i, j];
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
}