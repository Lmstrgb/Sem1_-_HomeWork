// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

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
      Console.WriteLine("Просили же ввести числа...");
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

// Функция поиска положительных чисел в массиве
int FindPosotiveNum(string[] Mass1)
{
  int count = 0;
  if (InputInt(Mass1))
  {
    foreach (string el in Mass1)
    {
      count += Convert.ToInt32(el) > 0 ? 1 : 0;
    }
  }
  return count;
}

//Функция перевода строки с пробелами в массив строк
// string[] StrSplit(string StrForSplit)
// {
//   string[] splitString = StrForSplit.Split(' ');
//   return splitString;
// }


string StrInput = InputStr("Введите числа через пробел: ");
string[] StrMass = StrInput.Split(' '); ;
int countMain = FindPosotiveNum(StrMass);


Console.WriteLine($"Полученный массив: [{String.Join(" ", StrMass)}] , количество положительных чисел = {countMain}");


