/* 
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 
*/

/*
Console.Write("Введите трехзначное число: ");

int number = int.Parse(Console.ReadLine());
string stringNumber = Convert.ToString(number);

Console.WriteLine($"Вторая цифра числа {number}: {stringNumber[1]}");
/*


/*
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(number%100/10);
*/

void SecondNumber(int a) 
{
    int number = a;
    int secNum = number % 100 / 10;
    Console.WriteLine("Вторая цифра числа: " + Math.Abs(secNum));
}

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

SecondNumber(number);