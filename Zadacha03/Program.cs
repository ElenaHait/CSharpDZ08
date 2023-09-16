// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] userArray = CreateTripleMatrix();
PrintTripleArray(userArray);


int[,,] CreateTripleMatrix(int n = 2, int m = 2, int k = 2)
{
    Random random = new Random();
    int[,,] array = new int[n, m, k];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                array[i, j, l] = random.Next(10, 100);
            }
        }
    }
    return array;
}

void PrintTripleArray (int[,,] array)
{
    for (int i = 0; i <array.GetLength(0); i++)
    {
        int k;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.WriteLine($"{array[i, j, k = 0]}({i}, {j}, {0})  {array[i, j, k = 1]}({i},{j},{1})");
            System.Console.WriteLine();
        }
    }
}
