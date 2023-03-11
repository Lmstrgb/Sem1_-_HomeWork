// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//Функция наполнения массива случайными вещественными числами
void FuncFillMassRandomDouble(double[] mass4)
{
  for (int i = 0; i < mass4.Length; i++)
  {
    mass4[i] = new Random().NextDouble() * 100; //Random().Next(-100, 100) + 
    mass4[i] = Math.Round(mass4[i], 3);
  }
  //Console.WriteLine("Сгенерированный массив: {0,8:N3}",(String.Join(" ", mass4)));
  Console.WriteLine($"Сгенерированный массив: [{String.Join(" ", mass4)}]");
  //("{0,8:N3}", rand.NextDouble()*100);
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


//Функция поиска разницы между максимальным и минимальным значениями
double MaxMinusMin(double[] mass5)
{
  double min = mass5[0];
  double max = mass5[0];
  foreach (double el in mass5)
  {
    min = el<min?el:min; //if(el<min) min=el;
    if(el>max) max=el;
  }
  return(max-min);

}

int number = InputInt("Введите размерность массива: ");
double[] mass = new double[number];
FuncFillMassRandomDouble(mass);
Console.WriteLine("Разница между максимальным и минимальным элемантами массива = {0}", MaxMinusMin(mass));