/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
 какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7 min = 5
a = 2 b = 10 -> max = 10 min = 2
a = -9 b = -3 -> max = -3 min = -9 */


/* Console.Clear();

Console.Write("Введите первое число: ");

string input1 = Console.ReadLine();

int numA = int.Parse(input1);


Console.Write("Введите второе число: ");

string input2 = Console.ReadLine();

int numB = int.Parse(input2);

int max = 0;
int min = 0;



if (numA > numB)

{   
    max = numA;
    min = numB;

    Console.WriteLine($"max = {max}, min = {min}");
}
else
{
    max = numB;
    min = numA;

    Console.WriteLine($"max = {max}, min = {min}");
} 
 */




/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт
 максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
 */


/* 
Console.Clear();

Console.Write("Введите первое число: ");

string input1 = Console.ReadLine();

int numA = int.Parse(input1);


Console.Write("Введите второе число: ");

string input2 = Console.ReadLine();

int numB = int.Parse(input2);

Console.Write("Введите третье число: ");

string input3 = Console.ReadLine();

int numC = int.Parse(input3);


int max = 0;

if (numA > numB)
{
max = numA;

}
else
{

max = numB;

}
 if(numC >max)
 {

max = numC;

 }
 else
 {

Console.WriteLine(max);

 } */


/*  Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
 является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */

/* 
Console.Clear();

Console.Write("Введите число: ");

string input = Console.ReadLine();

int num = int.Parse(input);

if(num % 2 == 0)
{
Console.WriteLine("Это число чётное");


}
else 
{
Console.WriteLine("Это число не чётное");


} */


/* Задача 8: Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */


Console.Clear();


Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int count = num - num + 2;

while(count <= num )
{

Console.WriteLine(count);

count = count + 2;

}