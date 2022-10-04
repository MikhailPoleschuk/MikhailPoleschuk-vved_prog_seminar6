// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите количество чисел:");
int M = Convert.ToInt32(Console.ReadLine());
int count=0;
for (int i=1;i<=M;i++)
{
Console.Write($"Введите число№ {i}:");
if (Convert.ToInt32(Console.ReadLine())>0) count++;
}
Console.Write($"положительных чисел {count} ");
