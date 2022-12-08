//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int  Foo( int m, int n)
   { if (m == 0)
        return n + 1;

   
   }
       
    for(m (in range (n + 2));
        m = Foo(m - 1, n+1);)
    

    return m;
   

Console.WriteLine("Введите число m");
int m = Convert.ToInt32 (Console.ReadLine());
 Console.WriteLine("Введите число n");
int n = Convert.ToInt32 (Console.ReadLine());  
Foo;