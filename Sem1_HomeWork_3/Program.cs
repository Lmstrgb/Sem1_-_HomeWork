
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

string DivBy2(int a)
{
  string result = "нечетное";
  if (a % 2 == 0)
  {
    result = "четное";
  }
  return result;
}

void PrintMass(int[] mass1, int b)
{
  int lenght = mass1.Length;
  string even, evenLast;
  evenLast = DivBy2(b);
  for (int i = 1; i < lenght; i++)
  {
    mass1[i] = i;
    even = DivBy2(mass1[i]);
    if (even == "четное")
    {
      Console.Write(" " + mass1[i]);
    }
  }

  if (evenLast == "четное") // костыль какой-то получился
  {
    Console.WriteLine(" " + b);
  }

}

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[num1];
PrintMass(mass, num1);

Console.Write($"{Environment.NewLine}Press any key to exit...");
Console.ReadKey(true);


