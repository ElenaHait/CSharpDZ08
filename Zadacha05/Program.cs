// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] userArray1 = CreateMatrix(2, 1);
int[,] userArray2 = CreateMatrix(1, 2);
PrintArray(userArray1);
System.Console.WriteLine();
PrintArray(userArray2);
int[,] multiplicationResult = MultiplicationMatrix(userArray1, userArray2);
System.Console.WriteLine();
PrintArray(multiplicationResult);

int[,] MultiplicationMatrix(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    int[] arrayRows1 = new int[array1.GetLength(1)];
    int[] arrayColumns2 = new int[array1.GetLength(0)];
    if (array1.GetLength(1) == array2.GetLength(0))
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int n = 0; n < array2.GetLength(1); n++)
            {
                arrayRows1 = GetRows(array1, i);
                arrayColumns2 = GetColumns(array2, n);
                int sum = 0;
                for (int j = 0; j < arrayRows1.Length; j++)
                {
                    sum = sum + arrayRows1[j] * arrayColumns2[j];
                }
                result[i, n] = sum;
            }
        }
    }
    else System.Console.WriteLine("Число столбцов 1 массива должно быть равным числу строк 2 массива!");
    return result;
}

int[] GetColumns(int[,] array, int col)
{
    int[] arrayCol = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        arrayCol[i] = array[i, col];
    }
    return arrayCol;
}

int[] GetRows(int[,] array, int rows)
{
    int[] arrayRow = new int[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        arrayRow[j] = array[rows, j];
    }
    return arrayRow;
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