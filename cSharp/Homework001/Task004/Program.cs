// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел.


Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1 ;

if (number1 == number2 && number1 == number3) Console.WriteLine("Числа равны");
    else
    {
        if (number1 >= number2 && number1 >= number3) max = number1;
            else 
            { 
                if (number2 >= number1 && number2 >= number3) max = number2 ;
                else max = number3 ;

            }
    Console.WriteLine($"max = {max}");
    }