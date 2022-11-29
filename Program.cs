// Задача 13: Напишите программу, которая выводит третью цифру(c начала) заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()); 
if (n < 100)
Console.WriteLine("третьего числа нет");
else
{
    while (n > 100)
    n = n / 10; 
    
    Console.WriteLine(n);
}