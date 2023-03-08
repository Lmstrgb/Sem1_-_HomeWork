// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

//Функция приветствия и проверки вводимого на признак числа
int InputInt(string msg)
{
  Console.Write(msg);
  string Str = Console.ReadLine()!;
  int res = 0;
  if (!int.TryParse(Str, out int num1))
  {
    Console.WriteLine("Просили же ввести число, попробуйте еще раз.");
    Console.Write($"{Environment.NewLine}Press any key to exit...");
    Console.ReadKey(true);
    Environment.Exit(0); //чтобы исключение не лезло
  }
  else { res = Convert.ToInt32(Str); }

  return res;
}


bool ValidateExp(int exp)
{
  if (exp < 0)
  {
    Console.WriteLine("Степень отрицательная");
    return false;
  }
  else return true;
}


int PlusExp(int baseOfDigit, int exponent)
{
  int digitInDegree = 1;
  for (int i = 0; i < exponent; i++)
  {
    digitInDegree *= baseOfDigit;
  }
  return digitInDegree;
}

//Функция возведения в отрицательную степень
double NegExp(double baseOfDigit, double exponent)
{
  if (baseOfDigit == 0)
  {
    Console.WriteLine("Ноль не может быть возведен в отрицательную степень");
    Console.Write($"{Environment.NewLine}Press any key to exit...");
    Console.ReadKey(true);
    Environment.Exit(0); //чтобы исключение не лезло
    return 0;
  }
  else
  {
    double digitInDegree = 1.0;
    for (int i = 0; i < Math.Abs(exponent); i++)
    {
      digitInDegree *= 1.0 / baseOfDigit;
    }
    return digitInDegree;
  }
}


int digit = InputInt("Введите число: ");
int exponent = InputInt("Введите стпень: ");
double digitDouble = Convert.ToDouble(digit);
double exponentDouble = Convert.ToDouble(exponent);

if (ValidateExp(exponent))
{
  Console.WriteLine($"Число {digit} в степени {exponent} равно {PlusExp(digit, exponent)}");
}
else
{
  Console.WriteLine($"Число {digit} в степени {exponent} равно {Math.Round(NegExp(digitDouble, exponentDouble), 5)}");
}

