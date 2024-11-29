using InspectorLib;
using System;
class Program
{
    static void Main (string[] args)
    {
        FunctionInsp InspectorLib = new FunctionInsp();
        try
        {
//Вызов метода (названия автоинспекции)
            Console.WriteLine($"Название автоинспекции: {InspectorLib.GetCarInspection}");
//Вызов метода (ФИО главного инспектора)
            Console.WriteLine($"ФИО главного инспектора: {InspectorLib.GetInspector}");
//Вызов исключения Exception
        
//Вызов метода (список всех сотрудников автоинспекции)
        Console.WriteLine($"Первичный список сотрудников автоинспекции"); 
        foreach (var GetWorked in InspectorLib.GetWorked) //Цикл foreach используется для вывода информации из массива
        {
            Console.WriteLine($"- {GetWorked}");
        }
//Вызов метода (добавление нового сотрудника + вывод обновлённого списка сотрудников)
        Console.WriteLine("Пожалуйста, введите ФИО нового сотрудника автоинспекции!"); 
        string newGetWorked = Convert.ToString(Console.ReadLine());
        bool success1 = InspectorLib.AddWorked(newGetWorked);
        Console.WriteLine($"Добавление нового сотрудника автоинспекции >> {newGetWorked} >> {(success1 ? "Успешно" : "Не успешно")}");
        Console.WriteLine($"Изменённый список сотрудников автоинспекции");
        foreach (var GetWorked in InspectorLib.GetWorked)
        {
            Console.WriteLine($"- {GetWorked}");
        }
//Вызов метода (замена старого главного руководителя на нового + вывод нового главного руководителя)
        Console.WriteLine("Введите ФИО сотрудника автоинспекции, которого хотите сделать главным!");
        string newGetInspector = Convert.ToString(Console.ReadLine());
        bool success = InspectorLib.SetInspector(newGetInspector);
        Console.WriteLine($"Изменение главного инспектора Васильева Василия Ивановича на >> {newGetInspector} >> {(success ? "Успешно": "Не успешно")}");
        if (success == true)
        {
            Console.WriteLine($"ФИО нового главного инспектора: {InspectorLib.GetInspector}");
        }
        else
        {
            Console.WriteLine($"Оставлено ФИО прежнего главного инспектора: {InspectorLib.GetInspector}");
        }
//Вызов метода (ввод данных о гос. номере автомобиля)
        Console.WriteLine("Пожалуйста, введите букву верхнего регистра вашего автомобиля");
        char symbol = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine(); //отступ
        Console.WriteLine("Пожалуйста, введите числовой номер вашего автомобиля");
        int number = int.Parse(Console.ReadLine());
//Вызов метода (вывод вашего гос. номера по введённым данным)
        string NumberCode = InspectorLib.GenerateNumber(symbol, number);
        Console.WriteLine($"Гос. номер вашего автомобиля >> {NumberCode}");
        }
//Вызов исключение на возникновения различных ошибок
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: Неверный формат номера.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла неизвестная ошибка: {ex.Message}");
        }
    }
}
