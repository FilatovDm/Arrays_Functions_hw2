/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

/*
Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(number);

if (stringNumber.Length > 2) Console.WriteLine($"Третья цифра числа {number}: {stringNumber[2]}");
else Console.WriteLine($"В числе {number} третьей цифры нет");
*/

void ThirdNumber(int a)
{
    int number = Math.Abs(a);
    if(number > 99)
    {
        while(number > 1000)
        {
            number = number / 10;
        }
        int result = number % 10;
        Console.WriteLine($"Третья цифра числа {a}: {result}");
    }
    else Console.WriteLine($"В числе {a} третьей цифры нет");
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

ThirdNumber(num);
