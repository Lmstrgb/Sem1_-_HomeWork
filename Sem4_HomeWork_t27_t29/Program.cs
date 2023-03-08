// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

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

//Функция число -> массив, состоящий из цифр числа
int[] FuncDigitToMass(int numf)
{
  int[] mass1 = new int[numf];
  for (int i = 0; i < mass1.Length; i++)
  {
    mass1[mass1.Length - i - 1] = numf % 10;
    numf = numf / 10;
  }
  return mass1;
}

//Функция определения суммы элементов в массиве
int FuncMassSumm(int[] mass2)
{
  int result = 0;
  for (int i = 0; i < mass2.Length; i++)
  {
    result += mass2[i];
  }
  return result;
}

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//Функция наполнения массива случайными часлами
void FuncFillMassRandom(int[] mass3)
{
  for (int i=0; i<mass3.Length; i++)
  {
    mass3[i] = new Random().Next(0,101);
  }
}


//Задача t25
// int digit = InputInt("Введите число: ");
// int[] mass = new int[digit];
// mass = FuncDigitToMass(digit);
// Console.WriteLine($"Сумма цифр числа {digit} = {FuncMassSumm(mass)}");

//Задача t29
int number = InputInt("Введите размерность массива: ");
int [] mass = new int[number];
FuncFillMassRandom(mass);
Console.WriteLine($"Сумма цифр числа {number} = [{String.Join(" ", mass)}]");
