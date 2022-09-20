﻿
/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("Input integer number A: ");
int numberA = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Input integer number B: ");
int numberB = Convert.ToInt32(Console.ReadLine ());
if (numberA > numberB)
{
 Console.WriteLine("Number A " + numberA + " > " + numberB);
}
 else
{
Console.WriteLine("Number B " + numberB + " > " + numberA);
}

/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Input 3 integer number: ");
int number1 = Convert.ToInt32(Console.ReadLine ());
int number2 = Convert.ToInt32(Console.ReadLine ());
int number3 = Convert.ToInt32(Console.ReadLine ());
int max_number = number1;

if (number2> max_number)
{
 max_number = number2;
}
if (number3> max_number)
{
 max_number = number3;
}
 

Console.WriteLine($"Number {max_number} is maximum");


/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Input integer number: ");
int number = Convert.ToInt32(Console.ReadLine ());
if (number % 2 == 1)
{
Console.WriteLine($"Number {number} is odd");
}
else
{
Console.WriteLine($"Number {number} is even");
}



/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/


int n = 1;
Console.WriteLine("Input integer number: ");
int current = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Even numbers from 1 to " + current);
while (n <= current)

if (current % 2 == 0)
{
Console.Write(current + " ");
current++;
}
else
{
Console.WriteLine("No even numbers")

}
