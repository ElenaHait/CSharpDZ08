
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



using System.Runtime.InteropServices;

int[,] userArray = CreateMatrix(4, 4);
PrintArray(userArray);
int[,] sortedUserArray = SortingMatrix(userArray);
Console.WriteLine();
PrintArray(sortedUserArray);

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

int[,] SortingMatrix(int[,] array)
{
    int[,] resultArray = new int[array.GetLength(0), array.GetLength(1)];
    int[] resultStr = new int[array.GetLength(1)];

    int[] GetRows(int[,] array, int rows) //создание строки
    {
        int[] arrayRow = new int[array.GetLength(1)];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arrayRow[j] = array[rows, j];
        }
        return arrayRow;
    }       

    void SortingStr (int[] stroka) //упорядочивание строки
{
    Array.Sort(stroka);
    Array.Reverse(stroka);
}    
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        resultStr = GetRows(array, i);
        SortingStr(resultStr);
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, k] = resultStr[k];
        }
    }
    return resultArray;

}