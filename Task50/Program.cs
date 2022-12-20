//Задача 50. Напишите программу, которая на вход 
//принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, 
//что такого элемента нет.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4

//17 -> такого числа в массиве нет


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}
bool FindNumber(int[,] array, int number)
{
    bool condition = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
                condition = true;
        }
    }
    return condition;
}
(int i, int j) FindPosition(int[,] array, int number)
{   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            return (i, j);
        }
    }
    return(-1, -1);
}


Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int cols = int.Parse(Console.ReadLine()!);

Console.Write("Введите число, которое будем искать в массиве: ");
int number = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, cols);

PrintArray(array);

if (FindNumber(array, number) is true)
    Console.WriteLine($"Число {number} найдено в массиве. Его координаты: {FindPosition(array, number)}");
else
    Console.WriteLine($"Число {number} не найдено в массиве.");