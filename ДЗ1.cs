/* Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
int numero1, numero2;

Console.WriteLine("Input a numero1");
numero1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a numero2");
numero2=Convert.ToInt32(Console.ReadLine());

if (numero1>numero2)
{
    Console.WriteLine("Numero1 is max and numero2 is min");
}
else 
{
    Console.WriteLine("Numero2 is max and numero1 is min");
} 
*/

/* ЗАДАЧА 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int num1, num2, num3;

Console.WriteLine("Please enter a num1");
num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter a num2");
num2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter a num3");
num3=Convert.ToInt32(Console.ReadLine());

if (num1>num2)
{
    if (num1>num3)
    {
        Console.WriteLine("Num 1 is max");
    }
    else
    {
        Console.WriteLine("Num 3 is max");
    }
}
    else 
{
    if (num2>num3)
    {
        Console.WriteLine("Num 2 is max");
    }
    else 
    {
        Console.WriteLine("Num 3 is max");
    }
}
*/

/* ЗАДАЧА 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
int num;

Console.WriteLine("Enter a number please");
num=Convert.ToInt32(Console.ReadLine());

if ((num/2)*2 == num)
{
    Console.WriteLine("This number is even");
}
else 
{
    Console.WriteLine("This number is uneven");
}
*/

/*ЗАДАЧА 4.Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int n, current;
Console.WriteLine("input a num");
n=Convert.ToInt32(Console.ReadLine());
current=1;

if ((n/2)*2 ==n)
{
    while(current <n)
    {
        Console.WriteLine(current=current+1);
        current=current+1;
    }
}
else
{
   while(current <n)
    {
        Console.WriteLine(current=current+1);
        current=current+1;
    } 
}
*/
