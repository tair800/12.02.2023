using _12._02._2023.Models;
using _12._02._2023.Task2.Models;

//Celcius celcius = new(100);
//Kelvin kelvin = celcius;
//Console.WriteLine(kelvin.K);

Employee employee1 = new("02.03.2000");
employee1.Name = "Tahir";
employee1.Surname = "Aslanli";
employee1.Salary = 2000;

Employee employee2 = new("04.03.1998");
employee2.Name = "Nihad";
employee2.Surname = "Memmedov";
employee2.Salary = 1500;

Employee employee3 = new("02.06.1990");
employee3.Name = "Mayis";
employee3.Surname = "Abbasli";
employee3.Salary = 3000;

Employee[] employees = { employee1, employee2, employee3 };
foreach (var item in employees)
{
    int count = 0;
    if (employees.Length > 2000)
    {
        count++;
        
        Console.WriteLine();
        return;

    }
}

