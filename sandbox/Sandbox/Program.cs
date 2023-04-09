using System;

namespace employee_demo
{

    class Program
    {
        static void Main(string[] args)
        {
            HourlyEmployee hEmployee = new HourlyEmployee();
            hEmployee.setName("Thompson");
            hEmployee.setIdNumber("123bcd");
            hEmployee.setPayRate(14);
            hEmployee.setHoursWorked(40);

            SalaryEmployee sEmployee = new SalaryEmployee();
            sEmployee.setName("Primrose");
            sEmployee.setIdNumber("009 ccd");
            sEmployee.SetSalary(2300);

            DisplayEmployeeInformation(hEmployee);
            DisplayEmployeeInformation( sEmployee);

            List<Employee> employees = new List<Employee>();
        
                employees.AddR();
                employees.Add(sEmployee);

                foreach (Employee emp in employees)
                {
                    float pay =emp.GetPay();
                }
        

        }
        public  static void DisplayEmployeeInformation( Employee employee)
        {
            ;
            float pay = employee.GetPay();
            Console.WriteLine($"{employee.GetName()}  will be paid ${pay}");
        }

    }



}