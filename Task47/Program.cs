//Задача 47. Задайте двумерный массив 
//размером m×n, заполненный случайными 
//вещественными числами.

//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

double[,] GetArray(double m, double n)
{
    double[,] result = new double[(int)m, (int)n];
    
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() * 10;
        }
    }
    return result;
}
void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write("{0,9:F2}", inArray[i, j]);
        }
        Console.WriteLine();
    }
}


Console.Write("Введите количество строк массива: ");
double rows = double.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
double cols = double.Parse(Console.ReadLine()!);

double[,] array = GetArray(rows, cols);
PrintArray(array);