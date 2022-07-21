//Домашнее задание 
//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*void ShowNUums (int first, int second)
{
    if (second > first)
    { 
        ShowNUums(first, second - 1);
    }
    Console.Write(second + " ");
}
Console.Write("Введите первое число:  ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:  ");
int second = Convert.ToInt32(Console.ReadLine());
ShowNUums(first, second);
*/


//Задача 64: Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.
/*int summa(int N)
{
    if (N >= 10)
    { 
        return N %10 + summa(N / 10);
    }
    else return N;
}
Console.Write("Введите число N:  ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(summa(N));
*/


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*int Summa(int m, int n)
{
    if (n > 1)
    { 
        return m + Summa(m+1, n-1);
    }
    return m;
}
Console.Write("Введите первое число:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Summa(m,n));
*/



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int Akkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {Akkerman} ");
*/