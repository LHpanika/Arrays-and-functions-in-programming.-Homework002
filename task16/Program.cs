// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет
Console.WriteLine("Введите первое число");
int numberA = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToBoolean(Console.ReadLine());

// if((numberA = numberB * numberB) ^ (numberB = numberA * numberA))
if ((numberA = numberB * numberB) | (numberB = numberA * numberA))
{
    Console.Write("Одно число - квадрат другого");
}
else
{
   Console.Write("Эти числа квадратно не спариваются:)"); 
}