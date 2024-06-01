//Задача: Учет сотрудников в компании.
//Разработайте программу для учета сотрудников в компании. Каждый сотрудник должен иметь имя, фамилию и должность. Реализуйте следующие функции:
//Добавление нового сотрудника в список.
//Удаление сотрудника по его фамилии.
//Поиск сотрудника по его имени или должности.
//Вывод списка всех сотрудников.
//Подсчет количества сотрудников в компании.

using System;
using System.Collections.Generic;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Position { get; set; }

    public Employee(string firstName, string lastName, string position)
    {
        FirstName = firstName;
        LastName = lastName;
        Position = position;
    }
}

public class EmployeeManagement
{
    private List<Employee> employees = new List<Employee>();

    public void AddEmployee(string firstName, string lastName, string position)
    {
        employees.Add(new Employee(firstName, lastName, position));
    }

    public void RemoveEmployeeByLastName(string lastName)
    {
        employees.RemoveAll(e => e.LastName == lastName);
    }

    public List<Employee> FindEmployeesByNameOrPosition(string query)
    {
        return employees.FindAll(e => e.FirstName == query || e.Position == query);
    }

    public void PrintAllEmployees()
    {
        foreach (var employee in employees)
        {
            Console.WriteLine($"Имя: {employee.FirstName} {employee.LastName}, Должность: {employee.Position}");
        }
    }

    public int CountEmployees()
    {
        return employees.Count;
    }
}

class Program
{
    static void Main()
    {
        EmployeeManagement management = new EmployeeManagement();

        management.AddEmployee("Ivan", "Ivanov", "Developer");
        management.AddEmployee("Jana", "Smirnova", "Manager");
        management.AddEmployee("Alisa", "Popova", "Designer");

        Console.WriteLine("Все работники:");
        management.PrintAllEmployees();

        Console.WriteLine("\nКоличество сотрудников: " + management.CountEmployees());

        Console.WriteLine("\nНайти сотрудников по имени 'Ivan':");
        List<Employee> foundEmployees = management.FindEmployeesByNameOrPosition("Ivan");
        foreach (var employee in foundEmployees)
        {
            Console.WriteLine($"Имя: {employee.FirstName} {employee.LastName}, Должность: {employee.Position}");
        }

        Console.WriteLine("\nУдалить сотрудника по фамилии 'Smirnova':");
        management.RemoveEmployeeByLastName("Smirnova");
        management.PrintAllEmployees();
    }
}
