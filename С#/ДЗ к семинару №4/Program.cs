/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

Ограничения:
- Нельзя использовать класс Math
- Должна быть отдельная функция Power, которая возвращает результат
- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода */

Console.Clear();
Console.WriteLine("Введите число A: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число B: ");
int num2 = int.Parse(Console.ReadLine()!);
int pow = num1;
Power(num1);
Console.WriteLine($"Число А в степени В = {pow}");


int Power(int num1)
{
int count = 2;

while (count <= num2)
    if (count <= num2)
    {

        pow = pow * num1;

        count++;
    }
return pow;
}
  


/* Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

Ограничения:
- Должна быть отдельная функция, которая возвращает результат суммы цифр
- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода */


Console.Clear();
Console.WriteLine("Введите число: ");
string input = Console.ReadLine()!;

int[] array = ParseToArray(input);
//int[] array = int.Parse(Console.ReadLine()!);

int sum = array[0];
Sum(array);
Console.WriteLine($"Сумма цифр числа составляет: {sum}");



int Sum(int[] array)

{   
    int count = 0;
    int size = array.Length;
    int i = 1;

    while (count < size - 1);
       if(count < size-1)
    {
        sum = sum + array[i];

        count++;

        i++;
    }
return sum;
}


/* 
Задача 29: Напишите программу, которая задаёт массив из 8 элементов
 и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]

Ограничения:
- Должна быть отдельная функция, которая создаёт массив и отдельная функция вывода
- Внутри функций (кроме функции вывода) НЕЛЬЗЯ использовать класс Console. 
Только в основном блоке кода или в функции вывода */

Я не понимаю как решить эти задачи.
Телеграмм 89507259018