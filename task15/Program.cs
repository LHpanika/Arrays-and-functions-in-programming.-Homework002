// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.WriteLine("Введите цифру от 1 до 7, соответсвующую дню недели ");
int number = Convert.ToInt32(Console.ReadLine());
// ТАК НЕ РАБОТАЕТ  if (number < 1 & number > 7)  
if (number < 1)
{
Console.Write("Такого дня недели не существует");
}
if (number > 7)
{
Console.Write("Такого дня недели не существует");
}
// if (number[1,5]) - так не работает
if (number == 1)
{
Console.Write("Это не выходной");
}
if (number == 2)
{
Console.Write("Это не выходной");
}
if (number == 3)
{
Console.Write("Это не выходной");
}
if (number == 4)
{
Console.Write("Это не выходной");
}
if (number == 5)
{
Console.Write("Это не выходной");
}
if (number == 6)
{
Console.Write("ВЫХОДНОЙ");
}
if (number == 7)
{
Console.Write("ВЫХОДНОЙ");
}