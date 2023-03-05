// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

//Функция проверки вводимого на признак числа
bool FuncIsNum(string str)
{
  bool checkDigit = int.TryParse(str, out int num1) ? true : false;
  if (!checkDigit)
  {
    Console.WriteLine("Просили же ввести число, попробуйте еще раз.");
    Console.Write($"{Environment.NewLine}Press any key to exit...");
    Console.ReadKey(true);
    Environment.Exit(0); //чтобы исключение не лезло
  }
  return checkDigit;
}


Console.WriteLine("Введите число");
string NumStr = Console.ReadLine()!;
bool checkNum = FuncIsNum(NumStr);
int Num = Convert.ToInt32(NumStr);
int[] MassNum = new int[Num+1];

if (checkNum)
{
  for (int i=0; i<=Num; i++)
  {
    MassNum[i]=(int)Math.Pow(i,3); // без (int) требовал переменную double в качестве аргумента Math.Pow
  }
}

var skip = MassNum.Skip(1);  //  MassNum = MassNum.Skip(1).ToArray(), вырезали первый элемент массива
Console.WriteLine(String.Join(", ", skip));