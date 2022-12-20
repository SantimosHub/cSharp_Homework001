// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

int N=0;

while (N < 3)
{
    Console.WriteLine("Введите число больше 2");
    int number = Convert.ToInt32(Console.ReadLine());
    N = number;
}

for (int i = 1; i <= N; i++)
{
    if (i % 2 != 0)
        continue;
    Console.Write($"{i},");
}

