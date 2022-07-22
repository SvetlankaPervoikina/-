//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*int UserNumbers(int[] newMassive)
{
  int count = 1;
  for (int i = 0; i < newMassive.Length; i++)
  {
    if(newMassive[i] > 0) count++; 
  }
  return count;

}

int InputNumbers(int m)
{
    int Kolich = 0;
    int[] newMassive = new int [m];
for (int i = 0; i < m; i++)
  {
        Console.Write($"Введите {i+1} число: ");
        newMassive[i] = Convert.ToInt32(Console.ReadLine());
        {
            if (newMassive[i] > 0) Kolich++;       
        }
        Console.Write($" Количество введенных чисел больше нуля {Kolich}" ); 
        Console.WriteLine();
  }
  return Kolich;
}

Console.Write($"Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] newMassive = new int[m];
UserNumbers(newMassive);
InputNumbers(m);

Console.WriteLine();

// int Count = 0;
//f (index [i] > 0) Count++; // как обратиться к значению индексов? 
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
