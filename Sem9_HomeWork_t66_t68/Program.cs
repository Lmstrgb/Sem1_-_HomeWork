// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int InputNum(string text)
{
  Console.WriteLine(text);
  return Convert.ToInt32(Console.ReadLine());
}

int SumRec(int m, int n)
{
  return n < m ? 0 : n + SumRec(m, n - 1);
}


int AkkermanFunc(int m, int n)
{
  if (m == 0)
  {
    return n + 1;
  }
  if (m > 0 && n == 0)
  {
    return AkkermanFunc(m - 1, 1);
  }
  return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));

}



int num1 = InputNum("Введите число m:");
int num2 = InputNum("Введите число n:");
//int sum = SumRec(num1,num2); //Задание 66

//Console.WriteLine($"Сумма чисел от m до n равна {sum}"); //Задание 66

Console.WriteLine(AkkermanFunc(num1, num2));//Задание 68 Функция Аккермана

