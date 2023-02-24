Console.WriteLine("Условие M не должно быть больше N");
Console.ReadKey();
Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

int PrintNumber(int Num1,int Num2)
{
  if(Num1 < Num2)
  {
    Console.WriteLine(Num2);
    return PrintNumber(Num1,(Num2-1));
  }
  else return Num1;
}
int PrintNumberRevers(int Num1,int Num2)
{
  if(Num1 < Num2)
  {
    Console.WriteLine(Num1);
    return PrintNumberRevers((Num1+1),Num2);
  }
  else return Num2;
}


Console.WriteLine();
Console.WriteLine(PrintNumber(M,N));
Console.WriteLine();
Console.WriteLine(PrintNumberRevers(M,N));