// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
System.Console.Write("Введите цифру - ");
int day = int.Parse(System.Console.ReadLine());
if (day == 7 | day == 6){
    System.Console.WriteLine("Это выходной!");
}
else if (day>7){
    System.Console.WriteLine("Такого дня недели нет");
}
else{
    System.Console.WriteLine("Это будний день");
}