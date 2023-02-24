Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
int PtintNumber(int n)
{
  if(n > 1)
  {
  Console.WriteLine(n);
  return PtintNumber(n - 1);
  }
  else return 1;
  

}

System.Console.WriteLine(PtintNumber(N));