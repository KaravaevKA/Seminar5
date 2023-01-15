//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end +1);
    }
    return RandomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите количество элементов в массиве");
int L = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число случайно генерируемого диапазона");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомый элемент");
int searched = Convert.ToInt32(Console.ReadLine());

int[] Array = CreateRandomArray (L, min, max);
ShowArray(Array);
for (int index = 0; index<Array.Length; index++)
{
    if (searched != Array[index]) 
    {
        Console.WriteLine("Такого числа нет");
    }
    else
    {
        Console.WriteLine("Да, такое число есть");
        break;
    }
}
