using System;

namespace EmployeeTest
{
    class Program
    {
        static void Main(string[] args)
        {
        Employee Employee1 = new Employee("James","Henry",9000.0);
        Employee Employee2 = new Employee("Bum","Gin",1000 );

        double tenPercentRaiseEmployee1 =  (10.0/100) * Employee1.MonthlySalary + Employee1.MonthlySalary;
        double tenPercentRaiseEmployee2 = (10.0/100*Employee2.MonthlySalary + Employee2.MonthlySalary);

        Console.WriteLine("{0} {1} the first Employee salary is {2}",Employee1.FirstName, Employee1.LastName, tenPercentRaiseEmployee1);
        Console.WriteLine("{0} {1} the second Employee salary is {2}",Employee2.FirstName, Employee2.LastName, tenPercentRaiseEmployee2);
        }
    }
}
