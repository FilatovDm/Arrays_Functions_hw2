/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

// Console.Write("Введите число, обозначающее день недели: ");
// int day = Convert.ToInt32(Console.ReadLine());
// if (day < 6) Console.WriteLine("Это будний день");
// else Console.WriteLine("Это выходной день");

Console.Write("Введите число, обозначающее день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

void CheckDay(int day)
{
    if (day < 6 & day > 0) Console.WriteLine("Это будний день");
    else if (day > 5 & day < 8) Console.WriteLine("Это выходной день");
    else Console.WriteLine("Вы ввели некорректное число");
}

CheckDay(day);