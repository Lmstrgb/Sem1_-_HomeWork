
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных 
//чисел в массиве.
// [345, 897, 568, 234] -> 2

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



//Функция наполнения массива случайными часлами
void FuncFillMassRandom(int[] mass3)
{
  for (int i = 0; i < mass3.Length; i++)
  {
    mass3[i] = new Random().Next(100, 1000);
  }
}

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


//Функция подсчета чётных чисел в массиве
void FuncQuantParity(int[] mass2)
{
  int count = 0;
  for (int i = 0; i < mass2.Length; i++)
  {
    if (mass2[i] % 2 == 0)
      count++;
  }
  Console.WriteLine("Количество чётных в массиве {0}", count);
}

//Функция подсчёта количества элементов массива, стоящих на нечетных позициях
void FuncQuantNotParity(int[] mass1)
{
  int summ = 0;
  for (int i = 0; i < mass1.Length; i++)
  {
    if (i % 2 != 0)
      summ+=mass1[i];
  }
  Console.WriteLine("Сумма элементов, стоящих на нечётных позициях в массиве: {0}", summ);
}

//Задача t34 и задача t36
int number = InputInt("Введите размерность массива: ");
int [] mass = new int[number];
FuncFillMassRandom(mass);
Console.WriteLine($"Сгенерированный массив: [{String.Join(" ", mass)}]");

//Задача t34
//FuncQuantParity(mass);

//Задача t36
FuncQuantNotParity(mass);



