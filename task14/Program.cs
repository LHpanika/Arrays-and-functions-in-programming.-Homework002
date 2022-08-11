// Задача 14: Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());

// **попытка 1**
// int mod = numberA % 7 & numberA % 23;
// if(mod == 0)
// {
//    Console.Write("кратно");
// }
// else
// {
//   Console.Write($"не кратно, остаток {mod}"); 
//}
if (numberA % 3 == 0 & numberA % 23 == 0)
{
   Console.Write("кратно");
}
else 
{
Console.Write("Это число не кратно 3 и 23");
}