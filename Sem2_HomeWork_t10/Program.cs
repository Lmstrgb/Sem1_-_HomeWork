//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Random rand = new Random();
// int num = rand.Next(10,100);
// Функция проверки на кол-во знаков в числе
int FuncQuantNum(int a, int quatity)
{
  int i;
  for (i = 0; a > 0; i++)
  {
    a = a / 10;
  }
  //Console.WriteLine("Данное число содержит цифр: " + i );
  if (i != quatity)
    Console.WriteLine("Введённое число не " + quatity + "-х значное");

  return i;
}

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


Console.Write("Введите трёхзначное число: ");
string numStr = Console.ReadLine()!; // кроме (!) можно еще было вместо string поставить var
int result, QuantNum;
//bool checkDigit = int.TryParse(numStr, out int num);
bool checkDigIntro = FuncIsNum(numStr)!;
int num = Convert.ToInt32(numStr);
QuantNum = FuncQuantNum(num, 3);

if (checkDigIntro & QuantNum == 3)
{
  //Console.WriteLine("Вы ввели число {0}", num);
  result = (num % 100) / 10;
  Console.WriteLine($"Вторая цифра: {result}");
}
else Console.WriteLine("Что-то пошло не так...");

