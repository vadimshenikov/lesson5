//Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine("Введите позицию элемента x: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите позицию элемента y: ");
int y = int.Parse(Console.ReadLine());

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

void searchElementArray(int[,] arr, int x, int y)
{
    bool element = false;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) {
            if((i == x) && (j == y))
            {
                Console.Write("Запрашиваемый элемент - {0} ", arr[i, j]);
                element = true;
            }
        }
    }
    if(!element)
    {
        Console.WriteLine("Запрашиваемый элемент не найден");
    }
}

int[,] arr = fillArray(10,8);
printArray(arr);

searchElementArray(arr, x,y);