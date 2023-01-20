//Вывод суммы элементов массива с нечетными индексами
int[] RandomArray(int N)
{
    int[] RandomArray = new int[N];
    for(int i = 0; i<N; i++)
    {
        RandomArray[i]=new Random().Next(-99, 100);

    }
    for (int i = 0; i<N; i++)
    {
        Console.Write(RandomArray[i] + " ");
    }
    Console.WriteLine();
    return RandomArray;
}
void Nechet(int[] Arr)
{
    int sum = 0;
    for (int i = 1; i<Arr.Length; i= i+2)  //[ 0 1 2 3 4 5 ... ]
    {
        sum += Arr[i];
    }
    Console.WriteLine($"Сумма элементов с нечетными индексами равна {sum}");
}
Console.WriteLine("Здравствуйте! Укажите количество элементов массива");
int Num = Convert.ToInt32(Console.ReadLine());
int[] Array = RandomArray (Num);
Nechet(Array);
