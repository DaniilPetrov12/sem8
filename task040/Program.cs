// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

System.Console.WriteLine("Введите первое число a = ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите первое число b = ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите первое число c = ");
int c = Convert.ToInt32(Console.ReadLine());

if (a + b > c && a+c>b && c+b >a)
{
    System.Console.WriteLine("Треугольник существует");
}
else{
    System.Console.WriteLine("Не существует");
}
