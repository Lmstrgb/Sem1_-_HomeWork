//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.






Random rand = new Random();
int num = rand.Next(1,8);
//Console.Write("Введите число: ");
//int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Наш номер дня: {num}");

if (num > 0 & num < 9)
{
  string[] mass = { "нет", "нет", "нет", "нет", "нет", "выходной", "выходной" };
  Console.WriteLine($"Сегодня выходной день? {mass[num - 1]}");
}
else Console.WriteLine($"Дня не существует такого: ");