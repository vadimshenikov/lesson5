//Задача 2: Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.
int[,] fillArray(int x, int y)
{
    int[,] mas = new int[x, y];
    Random random = new Random();

    for(int i=0; i<x;i++)
    {
        for(int j=0; j<y; j++)
        {
            mas[i,j] = random.Next(0,100);
        }
    }
    return mas;
}
void printArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
       {
        for (int j = 0; j < arr.GetLength(1); j++) {
            Console.Write("{0} ", arr[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] replaceRowArray(int[,] arr)
{
    int[] firstLine = new int[arr.GetLength(0)-1];
    int[] secondLine = new int[arr.GetLength(1)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) {
            if(i == 0)
            {
                firstLine[j] = arr[i, j];
            }
            if(i == arr.GetLength(0)-1)
            {
                secondLine[j] = arr[i, j];
                arr[i, j] = firstLine[j];
            }
        }
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) {
            if(i == 0)
            {
                arr[i, j] = secondLine[j];
            }
        }
    }
    return arr;
}

void printArr(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}
int[,] arr = fillArray(5,4);
Console.WriteLine("Исходный массив:");
printArray(arr);
Console.WriteLine(" ");
Console.WriteLine("После смены строк массива:");
printArray(replaceRowArray(arr));

