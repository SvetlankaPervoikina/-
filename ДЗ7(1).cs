// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
/*double[,] Make2DArray(int rows, int columns, int min, int max) 
{
    double[,] myMassive = new double [rows, columns];
        for (int i = 0; i < myMassive.GetLength(0); i++)
            for (int j = 0; j < myMassive.GetLength(1); j++)
                myMassive[i,j] = new Random(). Next(min, max+1) + new Random().NextDouble();
        return myMassive;
}

void ShowMake2DArray(int[,] array) 
{
     for (int i = 0; i < myMassive.GetLength(0); i++)
        for (int j = 0; j < myMassive.GetLength(1); j++) 
            Console.Write(array [i,j]+ "  ");
        Console.WriteLine();
}
Console.Write("Введите количество строк: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите min значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите max значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] arrayMy = Create2DigitsArray[a,b,min,max];
ShowMake2DArray(arrayMy);
*/





// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*int[,] CreateNewArray(int rows, int columns, int min, int max) 
{
    int[,] myNewMassive = new int [rows, columns];
        for (int i = 0; i < myMassive.GetLength(0); i++)
            for (int j = 0; j < myMassive.GetLength(1); j++)
                myNewMassive[i,j] = new Random(). Next(min, max+1);
        return myNewMassive;
}
int YourNumber(int[,] array)
{
    Console.Write("введите первый индекс числа:  ");
    int first = Convert.ToInt32(Console.ReadLIne());
    Console.Write("введите второй индекс числа:  ");
    int second = Convert.ToInt32(Console.ReadLIne());
    int UserNumber = 0; // нужно ли тут это?
    for (int i = 0; i < myMassive.GetLength(0); i++)
        for (int j = 0; j < myMassive.GetLength(1); j++)
        {
            if (i = first && j = second) UserNumber = array[i,j]
        }
        else 
        {
            Console.WriteLine("Элемента с такими индексами не существует!");
        }
    return UserNumber;   
}
void ShowCreateNewArray(int[,] array) 
{
     for (int i = 0; i < myNewMassive.GetLength(0); i++) // такое ли имя у массива? 
        for (int j = 0; j < myNewMassive.GetLength(1); j++) 
            Console.Write(array [i,j]+ "  ");
        Console.WriteLine();
}
Console.Write("Введите количество строк: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите min значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите max значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] IamMassive = CreateNewArray[a,b,min,max];
ShowCreateNewArray(IamMassive);
Console.WriteLine("ваше число " + YourNumber(IamMassive));
*/



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*int[,] Create2DigitsArray(int rows, int columns, int min, int max) // создали рандомный массив
{
    int[,] myMassive = new int [rows, columns];
        for (int i = 0; i < myMassive.GetLength(0); i++)
            for (int j = 0; j < myMassive.GetLength(1); j++)
                myMassive[i,j] = new Random(). Next(min, max+1);
        return myMassive;
}
double Mean(int[,] array) // нахождение ср.ар по 1 столбцу (где i = 0)
{
    int sum = 0;
    for (int i = 0; i < myMassive.GetLength(0); i++)
        for (int j = 0; j < myMassive.GetLength(1); j++) 
        sum = sum + array [0;j];
        mean = sum / array.GetLength(1);
    return mean;
}
void ShowCreate2DigitsArray(int[,] array) // вызов метода генерации рандомного массива 
{
     for (int i = 0; i < myMassive.GetLength(0); i++)
        for (int j = 0; j < myMassive.GetLength(1); j++) 
            Console.Write(array [i,j]+ "  ");
        Console.WriteLine();
}
Console.Write("Введите количество строк: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите min значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите max значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] arrayMy = Create2DigitsArray[a,b,min,max];
ShowCreate2DigitsArray(arrayMy);
Console.WriteLine("Среднее арифметическое " + Mean(arrayMy));
*/

