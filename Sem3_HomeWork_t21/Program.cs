// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


//Функция проверки вводимого на признак числа
bool FuncIsNum(string str)
{
  bool checkDigit = int.TryParse(str, out int num1) ? true : false;
  if (!checkDigit)
  {
    Console.WriteLine("Просили же ввести число, попробуйте еще раз.");
    Console.Write($"{Environment.NewLine}Press any key to exit...");
    Console.ReadKey(true);
    Environment.Exit(0); //чтобы исключение не лезло
  }
  return checkDigit;
}


int[] pointA = new int[3];
int[] pointB = new int[3];
bool NumOrNo;
double distance;
Console.WriteLine("Input coordinates of point A: X, Y, Z one by one");
for (int i = 0; i < pointA.Length; i++)
{
string pointAstr = Console.ReadLine()!; 
NumOrNo = FuncIsNum(pointAstr);
pointA[i] = Convert.ToInt32(pointAstr);
}

Console.WriteLine("Input coordinates of point B: X, Y, Z one by one");
for (int i = 0; i < pointB.Length; i++)
{
  string pointBstr = Console.ReadLine()!; 
  NumOrNo = FuncIsNum(pointBstr);
  pointB[i] = Convert.ToInt32(pointBstr);
}

distance = Math.Sqrt(Math.Pow((pointB[0]-pointA[0]),2) + Math.Pow((pointB[1]-pointA[1]),2) + Math.Pow((pointB[2]-pointA[2]),2));
distance = Math.Round(distance, 2);
Console.WriteLine("Расстояние между точками :" + distance);
