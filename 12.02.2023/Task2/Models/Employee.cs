

namespace _12._02._2023.Task2.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Birthday { get; set; }
        public double Salary { get; set; }

        public Employee(string birthday, double salary)
        {
            Birthday = birthday;
            Salary = salary;    
        }
        public Employee(string birthday) 
        {
            Birthday = birthday;
        }

       
        

    }
    
}
