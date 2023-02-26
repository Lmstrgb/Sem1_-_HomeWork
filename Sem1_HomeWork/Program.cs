
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


void MaxFunc(int a, int b)
{
  int max, min;
  if (a > b)
  {
    max = a;
    min = b;
    
  }
  else
  {
    max = b;
    min = a;
  }

  Console.WriteLine("Max = " + max);
  Console.WriteLine("Min = " + min);
}

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

MaxFunc(num1, num2);
