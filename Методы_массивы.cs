// 1 метод. Генерация массива из рандомных целочисленных значений

int [] CreateRandomArray (int size, int minValue, int maxValue)
{
    int [] newArray = new int [size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue+1);
    return newArray;
}


// 2 метод. Генерация массива из целочисленных значений, заданных пользователем

int [] CreatArray (int size)
{
    int [] newArray = new int [size];
    Console.WriteLine("Creating array here:  ");

    for (int i = 0; i < size; i++)
    { 
        Console.Write($"Input {i+1} element:  ");
        newArray [i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    
    return newArray;
}


// 3 метод. Вывод массива на экран 
void ShowArray (int []array)
{
    for (int i = 0; i < array.Length; i++);
        Console.Write(array [i] + "  ");
    Console.WriteLine();
}