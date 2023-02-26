//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

string DivBy2(int a)
{
  string result = "нечетное";
  if (a % 2 == 0)
  {
    result = "четное";
  }
  return result;
}

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
string result = DivBy2(num1);
Console.WriteLine("Число " + num1 + " - " + result);

