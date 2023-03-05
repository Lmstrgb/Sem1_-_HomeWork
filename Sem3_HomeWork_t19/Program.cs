// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Функция проверки на кол-во знаков в числе
int FuncQuantNum(int a, int quatity)
{
  int i;
  for (i = 0; a > 0; i++)
  {
    a /= 10;
  }
  //Console.WriteLine("Данное число содержит цифр: " + i );
  if (i != quatity)
  {
    Console.WriteLine("Введённое число не " + quatity + "-х значное");
    Console.Write($"{Environment.NewLine}Press any key to exit...");
    Console.ReadKey(true);
    Environment.Exit(0); //чтобы исключение не лезло
  }
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

//Функция число -> массив, состоящий из цифр числа
int[] FuncDigitToMass(int q, int numf)
{
  int[] mass1 = new int[q];
  for (int i = 0; i < mass1.Length; i++)
  {
    mass1[mass1.Length - i - 1] = numf % 10;
    numf = numf / 10;
  }
  return mass1;
}




Console.WriteLine("Введите число: ");
string numInStr = Console.ReadLine()!; // можно вместо string использовать var или оператор прощения !
bool checkDigIntro = FuncIsNum(numInStr);
int num = Convert.ToInt32(numInStr);
int count = 0;
int Quant = FuncQuantNum(num, 5);
int[] mass = FuncDigitToMass(Quant, num);

for (int i = 0; i < (mass.Length / 2); i++)
{
  if ((mass[i] != mass[mass.Length - i - 1]) & checkDigIntro & Quant < 6)
  {
    Console.WriteLine($"Число " + num + " - не палиндром");
    break;
  }
  else
    count++; // если просто написать тут вывод на экран, то два раза будет выводить, поэтому прибегнул к такому
}

if (count==(Quant-1)/2)
Console.WriteLine($"Число " + num + " - палиндром");



//int buf; //??

//Console.WriteLine("Массив сформирован \a"+ "Абракадабра"  );
//Console.WriteLine(String.Join(" ", mass));

