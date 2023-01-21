int[] RandomArray(int N)
{
    int[] RandomArray = new int[N];
    for(int i = 0; i<N; i++)
    {
        RandomArray[i]=new Random().Next(1, 100);

    }
    for (int i = 0; i<N; i++)
    {
        Console.Write(RandomArray[i] + " ");
    }
    Console.WriteLine();
    return RandomArray;
}

Console.WriteLine("Здравствуйте! Укажите количество элементов массива");
int Num = Convert.ToInt32(Console.ReadLine());
int[] Array = RandomArray (Num);
Console.WriteLine($"Разница = {GetDifference(Array)}");
int GetDifference(int[] array)
{
int max = array[0];
int min = array[0];
foreach(var item in array)
{
    if(min>item) min = item;
    if(max<item) max = item;
}
return max-min;
}