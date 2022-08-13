// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//1 способ
string random = new Random().Next(1, 1000000).ToString();
System.Console.WriteLine($"Случайное число №1 - {random}");

if (random.Length > 2) System.Console.WriteLine($"Его третья цифра - {random[2]}");
else System.Console.WriteLine("Число меньше трехзначного");
System.Console.WriteLine("--------------------------------");

//2 способ
int random_1 = new Random().Next(1, 1000000);
System.Console.WriteLine($"Случайное число №2 - {random_1}");

if (random_1 > 99)
{
    System.Console.WriteLine($"Его третья цифра - {Third_number(random_1)}");
}
else
{
 System.Console.WriteLine("Число меньше трехзначного"); 
}



int Third_number(int number){
    int return_number = number;
    while (true)
    {
        if (return_number/10 > 99) return_number/=10;
        else return return_number%10;
    }
}