// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[num];

// for (int index = 0; index < num; index++) 
// {
//     array[index] = ((index + 1) * (index + 1) * (index + 1));
//     Console.WriteLine(array[index]);
// }


// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите первое число A: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе  число B: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int[] array = new int[2] { num1, num2 };
for (int index = 0; index < num2; index++)
{
int i = Convert.ToInt32(Math.Pow(num1, num2));
 Console.WriteLine("A ^ B = " + Math.Pow(num1, num2));
}
// int i = Convert.ToInt32(Math.Pow(5, 3))