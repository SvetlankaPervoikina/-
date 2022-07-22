// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SummaChisel(int i)
{
    int result = 0;
    while (i > 0)
        {
            int num = i % 10;
            i = i / 10;
            result = result + num;
        }
        return result;
}
Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());

int result = SummaChisel(num); 
Console.WriteLine($"Сумма цифр в числе {num} равна {result}");
*/

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
int[]RandomMassive (int m, int minValue, int maxValue)
{
    int [] newMassive = new int [m];
    for (int i = 0; int i < m; i++);
    
    newMassive [i] = new Random().Nex(minValue, maxValue+1);
return newMassive (int [] array);
}
void newMassive (int[]array)
{
    for (int i=0; i<array.Length; i++) Console.Write("Array[i]+ "  );

Console.WriteLine();
}
    
Console.WriteLine("Введите размер массива:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный предел массива:  ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный предел массива:  ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int RandomMassive(m);
*/



