
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

void MaxFunc(int a, int b, int c)
{

  int max=a;
  if (max < b)
  {
    max = b;   
  }
  if (max < c)
  {
    max = c;
  }

  Console.WriteLine("Max = " + max);

}

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

MaxFunc(num1, num2, num3);