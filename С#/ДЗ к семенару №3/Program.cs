/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет,
 является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */

/* 
Console.Clear();
Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
int len = num.Length;

if (len == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine($"{num} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{num} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($" {num} - Число не является пятизначным");
}
 */


/* 
 Задача 21

Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */


/* 
Console.Clear();
Console.WriteLine("Введите координаты X для A: ");
double xa = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты X для B: ");
double xb = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты Y для A: ");
double ya = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты Y для B: ");
double yb = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты Z для A: ");
double za = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты Z для B: ");
double zb = double.Parse(Console.ReadLine()!);

double d = Math.Sqrt (Math.Pow((xa-xb),2) + Math.Pow((ya - yb),2) + Math.Pow((za - zb),2));
d = Math.Round(d, 2);
Console.Write($"Длина отрезка = {d:f2}"); */



/* Задача 23

Напишите программу, которая принимает на вход число (N)
 и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */


Console.Clear();
Console.WriteLine("Введите число: ");
double num = double.Parse(Console.ReadLine()!);
double count = 1;


while (count <= num)
{
    Console.Write(Math.Pow((count), 3));
        if (count != num)

        Console.Write(", ");

    count++;
}
//Я не понимаю почему эта херня не работает!!!
//Никаких ошибок, просто ничего не происходит после ввода числа.



