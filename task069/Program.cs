// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Squar(int number2,int number1)
{
    if (number2 == 0)
    {
        return 1;
        
    }
    return number1*Squar(number2-1,number1);
}


System.Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Squar(number2,number1));