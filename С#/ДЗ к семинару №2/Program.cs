/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число

 и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

/* 
Console.Clear();

Console.WriteLine("Введите трехзначное число:  ");

string input = Console.ReadLine();

int num = int.Parse(input);

if((num < 1000) & (num > 99))
{

    num = ((num / 10) % 10);

        Console.WriteLine(num);
}

else
   {

Console.WriteLine("Число не трехзначное");


   }
 */
    
/* 
Задача 13: Напишите программу, которая выводит третью цифру
 заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
 */

/* Console.Clear();

Console.WriteLine("Введите число ");

string input = Console.ReadLine();

int num = int.Parse(input);

if (num <= 99)

    Console.WriteLine("третьего числа нет");

if (num < 0)

    Console.WriteLine(input[3]);

 else

    Console.WriteLine(input[2]); */






/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */
 
Console.Clear();
Console.WriteLine("Введите число ");

string input = Console.ReadLine();

int num = int.Parse(input);

string[] week = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

if (num > 7 || num <= 0)
{

     Console.WriteLine("Введёное число не соответствует колличеству дней в неделе ");
}

else

    num = (num - 1);

if (num == 6  || num == 7)

Console.WriteLine($"{week[num]} Выходой!");

else

    Console.WriteLine(week[num]);
    
