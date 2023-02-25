Console.WriteLine("Введите первое число:");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество элементов");
int CountNumber = Convert.ToInt32(Console.ReadLine());

int Fibonacci(int n, int m, int num)
{
  if (num == 1) return n;
  if (num == 2) return m;
  return Fibonacci(n, m, num - 1) + Fibonacci(n, m, num - 2);
}
void PrintNums(int x, int y, int n)
{
  Console.WriteLine();
  for (int i = 1; i <= n; i++)
    Console.Write(Fibonacci(x, y, i) + " ");
}

PrintNums(N,M,CountNumber);