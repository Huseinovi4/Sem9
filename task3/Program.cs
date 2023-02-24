Console.WriteLine("Условие что бы M было меньше N");
Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int Sum = 0;
int SummElementsInRange(int Num1,int Num2,int sum)
{
  if(Num1 < Num2)
  {
    sum = sum + Num1;
    return SummElementsInRange(Num1 + 1,Num2,sum);
  }
  else
  {
    sum = sum + Num2;
    Console.Write("Сумма элементов равна:");
    return sum;
  }
}
Console.WriteLine();
Console.WriteLine(SummElementsInRange(M,N,Sum));
