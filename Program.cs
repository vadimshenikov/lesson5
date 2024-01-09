//Задача 3: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
//с наименьшей суммой элементов.
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

int[] summLineArray(int[,] arr)
{
    int[] summLine = new int[arr.GetLength(0)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) {
                summLine[i] = summLine[i] + arr[i, j];
        }
    }
    return summLine;
}

int[] searchMinElementArr(int[] arr)
{
    int tmpMin = arr[0];
    int index = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(tmpMin > arr[i])
        {
            tmpMin = arr[i];
            index = i;
        }
    }
    return [tmpMin, index];
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
Console.WriteLine("Сумма строк:");
int[] a = summLineArray(arr);
printArr(a);
Console.WriteLine("Минимальная сумма эллементов строк:");
Console.WriteLine(searchMinElementArr(a)[0]);
Console.WriteLine("Позиция строки с минимальной суммов элементов (подсчет с 0):");
Console.WriteLine(searchMinElementArr(a)[1]);
