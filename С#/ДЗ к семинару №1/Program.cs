/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
 какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7 min = 5
a = 2 b = 10 -> max = 10 min = 2
a = -9 b = -3 -> max = -3 min = -9 */


Console.Clear();

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
