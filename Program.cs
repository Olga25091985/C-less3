//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
// Console.Write("Введите число1 ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число2 ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 > num2)
// {
// Console.Write (num1);
// }
// else
// {
// Console.Write (num2);
// }

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
// Console.Write("Введите число1 ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число2 ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число3 ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// if (num1 > num2 && num1 > num3)
// {
// Console.Write (num1);
// }
// if (num2 > num1 && num2 > num3)
// {
// Console.Write (num2);
// }
// else
// {
// Console.Write (num3);
// }

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 2 != 0)
// {
// Console.Write ("Нечетное");
// }
// else
// {
// Console.Write ("четное");
// }

// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// while (i <= num)
// {
//     if (i % 2 == 0)
//     Console.Write(i +" , "); 
// i=i+1;
// }

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int result1 = num / 100;

Console.WriteLine(result1);

