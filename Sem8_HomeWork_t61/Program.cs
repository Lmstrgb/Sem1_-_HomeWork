//Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника


int InputNum(string text)
{
  Console.WriteLine(text);
  return Convert.ToInt32(Console.ReadLine());
}


int Factorial(int n)
{
  if ((n == 1) || (n == 0)) return 1;

  else return n * Factorial(n - 1);
}

//Функция треугольника Паскаля
void TrianglePascal(int n)
{
  int i, c;
  for (i = 0; i < n; i++)
  {
    for (c = 0; c <= (n - i); c++) //делает отступы после каждой строки n-i отступов от левой стороны консоли, чем ниже
                                   //строка тем меньше отступов
    {
      Console.Write(" ");
    }
    for (c = 0; c <= i; c++)
    {
      Console.Write(" "); // делаем пробелы м/д элементами треугольника
      Console.Write(Factorial(i) / (Factorial(c) * Factorial(i - c)));

    }
    Console.WriteLine();
    Console.WriteLine(); // после каждой строки отступаем 2 пустфе строчки
  }
  Console.WriteLine();
}



int numStr = InputNum("Введите количество строк: ");
TrianglePascal(numStr);