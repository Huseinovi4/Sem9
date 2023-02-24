Console.WriteLine("Введите два числа N и M");
Console.ReadKey();
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

int Accerman(int Num1, int Num2)
{
  if (Num1 == 0)
  {
    return Num2 + 1;
  }
  else
    if ((Num1 != 0) && (Num2 == 0))
  {
    return Accerman(Num1 - 1, 1);
  }
  else
  {
    return (Accerman(Num1 - 1, Accerman(Num1, Num2 - 1)));
  }
}

Console.WriteLine();
Console.Write("Результат функции равен: ");
Console.Write(Accerman(N, M));