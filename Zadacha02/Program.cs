// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка


int[,] arrayUser = CreateMatrix(4, 3);
PrintArray(arrayUser);
int min = MinSum(arrayUser);
System.Console.WriteLine($"Строка с наименьшей суммой элементов: {min}");


int MinSum(int[,] array)
{
    int[] sumRows = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        } 
        sumRows[i] = sum;
        
    }
    int minCount = sumRows[0];
    int result = default;
    for (int k = 0; k < sumRows.GetLength(0); k++)
    {
        if (sumRows[k] < minCount) 
        {
            minCount = sumRows[k];
            result = k;
        }
    }
    return result + 1;
}

int[,] CreateMatrix(int n, int m)
{
    Random random = new Random();
    int[,] array = new int[n, m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}
