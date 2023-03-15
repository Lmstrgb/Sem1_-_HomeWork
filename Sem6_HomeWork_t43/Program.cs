// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//Функция ввода и приветствия
string InputStr(string msg)
{
  Console.Write(msg);
  return Console.ReadLine()!;
}

//Функция проверки элементов вводимого массива на признак числа
bool InputInt(string[] splitedString)
{
  string select = String.Empty;
  for (int i = 0; i < splitedString.Length; i++)
  {

    if (!int.TryParse(splitedString[i], out int num1))
    {
      Console.WriteLine("Просили же ввести целые числа...");
      Console.Write($"{Environment.NewLine}Для продолжения выполнения программы без этого элемента массива нажмите y, для выхода нажмите n: ");
      select = Console.ReadLine()!;
      if (select == "n")
      {
        Console.Write($"{Environment.NewLine}Press any key for exit....");
        Console.ReadKey(true);
        Environment.Exit(0); //чтобы исключение не лезло
      }
      else if (select == "y")
      {
        Console.WriteLine("Введённая кваказябра будет заменена нулём");
        splitedString[i] = "0";
      }
    }
  }

  return true;
}


//Доп. функция перевода строки в массив целых чисел для TryParse


//Функция вычисления координат точки пересечения двух прямых и вывода на экран
void CrossLine(string[] mass1, string[] mass2)
{
  double[] mass4 = new double[mass1.Length];
  double[] mass5 = new double[mass2.Length];
  for (int k = 0; k < mass1.Length; k++)
  {
    mass4[k] = Convert.ToDouble(mass1[k]);
    mass5[k] = Convert.ToDouble(mass2[k]);
  }

  double X = Math.Round(((mass5[1] - mass4[1]) / (mass4[0] - mass5[0])), 4);
  double Y = Math.Round((mass4[0] * X + mass4[1]), 4);


  if (mass1[0] == mass2[0] & mass1[1] != mass2[1])
  {
    Console.WriteLine("Прямые параллельны");
  }
  else if (mass1[0] == mass2[0] & mass1[1] == mass2[1])
    Console.WriteLine("Прямые совпадают");
  else
    Console.WriteLine("Kоординаты точки пересечения двух прямых = {0} и {1}", X, Y);
}


string inputLine1 = InputStr("Введите коэффициенты первой примой (k1, b1): ");
string[] MassLine1 = inputLine1.Split(' ');

string inputLine2 = InputStr("Введите коэффициенты первой примой (k2, b2): ");
string[] MassLine2 = inputLine2.Split(' ');

if (InputInt(MassLine1) & InputInt(MassLine2))
  CrossLine(MassLine1, MassLine2);