//Подсчет четных трехзначных элеметов массива
int[] Task34(int N)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(100, 999 +1);
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
void ArrayCount(int[] Numbers)
{
    int i = 0;
    int sum = 0;
    while ( i < Numbers.Length)
    { 
        if (Numbers[i] % 2 ==0) 
        {
            sum++;
            i++;
        }
        else 
        {
            i++;
        } 

    }
    Console.WriteLine($"В массиве содержится {sum} четных элементов");
}

Console.WriteLine("Здравствуйте! Укажите количество элементов массива");
int Num = Convert.ToInt32(Console.ReadLine());
int[] Array = Task34 (Num);
ShowArray(Array);
ArrayCount(Array);