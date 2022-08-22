namespace EmployeeTest
{
     class Employee {

        public Employee(string firstname, string lastname, double monthlySalary)
        {
            if(monthlySalary < 0){ monthlySalary = 0; }
            
            FirstName = firstname;
            LastName = lastname;
            MonthlySalary = monthlySalary;  
         }

        public string FirstName {get; set;}
        public string LastName {get; set;}
        public double MonthlySalary {get; set;}
        
     }
}
