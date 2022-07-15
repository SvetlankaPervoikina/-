// Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*int[] Create3DigitsArray(int size)
{
    int[] newArray = new int [size];
    for (int i = 0; i < size; i++)
        newArray [i] = new Random().Next(100, 1000);
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i]+ "  ");
    Console.WriteLine();
}

void Kolichestvo(int[] myArray)
{
    int count = 0;
    for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i] %2 == 0)  count++;
        }
       
        Console.WriteLine("Количество четных чисел в массиве:  "+ count);
}

Console.Write("Введите длину массива:  ");
int a = Convert.ToInt32(Console.ReadLine());
int[] myArray = Create3DigitsArray(a);

ShowArray(myArray);
Kolichestvo(myArray);


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateDifferentArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int [size];
    for (int i = 0; i < size; i++)
        newArray [i] = new Random().Next(minValue, maxValue+1);
    return newArray;
}
void ShowArrayDif(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i]+ "  ");
    Console.WriteLine();
}
void SummaChisel(int[] myArray)
{
    int summa = 0;
    for (int i = 1; i < myArray.Length; i =i+2)
        {
            summa = summa + myArray[i];
        }
       
        Console.WriteLine("Сумма  нечетных элементов в массиве:  "+ summa);
}

Console.Write("Введите длину массива:  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите min значение:  ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите max значение:  ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateDifferentArray(a, min, max);

ShowArrayDif(myArray);
SummaChisel(myArray);
*/

// Задача 38:  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*double[] CreateDoubleArray(int size, int minValue, int maxValue)
{
    double[] newArray = new double [size];
    for (int i = 0; i < size; i++)
        newArray [i] = new Random(). Next(minValue, maxValue+1) + new Random().NextDouble();
    return newArray;
    
}
void ShowArrayDoub(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i]+ "  ");
    Console.WriteLine();
}

void ShowDoubVariance(double[] array)
{
    double maxNum = 0;
    double minNum = array[0];
    
    for (int i = 0; i < array.Length; i++)
    {
        if (maxNum < array[i])  maxNum = array[i];
        if (minNum > array[i])  minNum = array[i];
        
    }
    double raz = maxNum - minNum;
    
    Console.Write($"Разница между максимальным {maxNum} и минимальным {minNum} значениями равна:  "+ raz);
    Console.WriteLine();   
}

Console.Write("Введите длину массива:  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите min целое число:  ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите max целое число:  ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateDoubleArray(a, min, max);

ShowArrayDoub(myArray);
ShowDoubVariance(myArray);
*/