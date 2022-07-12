// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
int a=5, b=7;
if (a>b)
{
    Console.WriteLine($"Число {a} больше чем {b}");
}
else
{
    Console.WriteLine($"Число {b} больше чем {a}");
}
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int a, b, c;
Console.WriteLine("Введите первое число - ");
a = Convert.ToInt32(Console.Read());
Console.WriteLine("Введите второе число - ");
b = Convert.ToInt32(Console.Read());
Console.WriteLine("Введите третье число - ");
с = Convert.ToInt32(Console.Read());
if (c<a>b)
{
    Console.WriteLine($"Число {a} максимальное");
}
if(c<b>a)
{
    Console.WriteLine($"Число {b} максимальное");
}
else
{
    Console.WriteLine($"Число {c} максимальное");
}

//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным

int x=a;
while (x<b)
{
   if (a%2==0)
      {
         Console.WriteLine($"Число {a} четное");
      }
   x++;
}

//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

int a;                             
            Console.Write("введите число: ");
            a= Console.Read();
 
            if (a % 2==1)
            {
                Console.WriteLine("число нечетное");
           
            }
            else
            {
                Console.WriteLine("Число четное");
            }