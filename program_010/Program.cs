// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//1 способ
string random = new Random().Next(100,1000).ToString();

System.Console.WriteLine($"Трехзначное число №1 - {random}");
System.Console.WriteLine($"Его вторая цифра - {random[1]}");
System.Console.WriteLine("-------------------------------");

//2 способ
int random_1 = new Random().Next(100,1000);

System.Console.WriteLine($"Трехзначное число №2 - {random_1}");
if ((random_1/10)%10==0) System.Console.WriteLine("0");
else System.Console.WriteLine($"Его вторая цифра - {(random_1/10)%10}");

