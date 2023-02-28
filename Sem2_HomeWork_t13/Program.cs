
// Функция проверки на кол-во знаков в числе
int FuncQuantNum(int a, int quatity)
{
  int i;
  for (i = 0; a > 0; i++)
  {
    a = a / 10;
  }
  //Console.WriteLine("Данное число содержит цифр: " + i );
  if (i < quatity)
    Console.WriteLine("У введённого числа нет " + quatity + "-ей цифры");
  return i;
}


//Random rand = new Random();
//int num = rand.Next(1,10000);
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Случайно сгенерированное число: {num}");
int QuantNum = FuncQuantNum(num, 3);
int result=0;
if (QuantNum >= 3)
{
  for (int j = 0; j < QuantNum - 3; j++)
  {
    num = num / 10;
  }
  result = num % 10;
  Console.WriteLine($"Третья цифра: {result}"); 
}


