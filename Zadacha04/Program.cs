// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



int[,] tmpArray = MakeSpirale();
PrintArray(tmpArray);

int[,] MakeSpirale()
{
int[,] resultArray = new int[4, 4];
int num = 1;
for (int col = 0; col < resultArray.GetLength(0); col++)
{
    resultArray[0, col] = num;
    num++;
}
for (int row = 1; row < resultArray.GetLength(1); row++)
{
    resultArray[row, resultArray.GetLength(1)-1] = num;
    num++;
}
for (int j = resultArray.GetLength(1)-2; j >= 0; j--)
{
   resultArray[resultArray.GetLength(1)-1, j] = num;
    num++; 
}
for (int k = resultArray.GetLength(0)-2; k > 0; k--)
{
    resultArray[k, 0] = num;
    num++;
}
for (int m = 1; m < resultArray.GetLength(1)-1; m++)
{
    resultArray[1, m] = num;
    num++;
}
for (int t = resultArray.GetLength(1)-2; t > 0; t--)
{
    resultArray[2, t] = num;
    num++;
}

return resultArray;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(string.Format("{0:d2}", array[i, j])+ " ");
        }
        Console.WriteLine();
    }
}
