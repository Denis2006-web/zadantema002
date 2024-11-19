using System;

public class MyProgram
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Введите первое число:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        double num2 = Convert.ToDouble(Console.ReadLine());



        double sum = Summa(num1, num2);
        Console.WriteLine($"Сумма чисел: {sum}");


        // Проверка четности/нечетности
        Chet(num1);
        Chet(num2);

    }

    // Метод для сложения двух чисел
    static double Summa(double a, double b)
    {
        return a + b;
    }

    // Метод для определения четности/нечетности числа
    static void Chet(double num)
    {
        if (num % 2 == 0)
        {
            Console.WriteLine($"{num} - четное число");
        }
        else
        {
            Console.WriteLine($"{num} - нечетное число");
        }
    }

public class Пользователь
{
    public int Id { get; set; } 

    public string Имя { get; set; }
    public string Фамилия { get; set; }
    public string Отчество { get; set; }
    public DateTime ДатаРождения { get; set; }
    public string Пол { get; set; } 

    public string НомерКарты { get; set; }

    public Пользователь(string имя, string фамилия, string отчество, DateTime датаРождения, string пол, string номерКарты)
    {
        Имя = имя;
        Фамилия = фамилия;
        Отчество = отчество;
        ДатаРождения = датаРождения;
        Пол = пол;
        НомерКарты = номерКарты; 
    }
  }

}

