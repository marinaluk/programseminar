//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int NaturalNumber (int M,int N)
{
 if (M !=N)
  { 
    if (N>=M)
      { 
        NaturalNumber(M, N-1);
        Console.Write(N + " ");
        return N;
      }
    else
      {
        NaturalNumber(M-1, N);
        Console.Write(M +" ");
        return M;
      }
  }
  else return M ;
}

Console.WriteLine("Введите число M");
int M = Convert.ToInt32 (Console.ReadLine());
 Console.WriteLine("Введите число N");
int N = Convert.ToInt32 (Console.ReadLine());  

NaturalNumber ( M-1, N);
 int sum(int NaturalNumber)
{
    if (NaturalNumber == 1)
        return 1;
    else
        return sum(NaturalNumber - 1) + NaturalNumber;
}
  static void Main(string[] args)
  {

    Console.WriteLine(sum());
    Console.ReadLine();
  }

// Дальше я незнаю, что можно сделать.
