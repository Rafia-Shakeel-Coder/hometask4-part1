using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask4_qno_2
{
    public class Employee
    {
        public int employeeid { get; set; }
        public string employeename { get; set; }
        public string employeedepartment { get; set; }
        public double employeesalary { get; set; }
        public Employee(int id, string name, string department, double salary)
        {
            employeeid = id;
            employeename = name;
            employeedepartment = department;
            employeesalary = salary;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("IDENTITY OF EMPLOYEE {0}", employeeid);
            Console.WriteLine("NAME OF EMPLOYEE {0}", employeename);
            Console.WriteLine("DEPARTMENT OF EMPLOYEE {0}", employeedepartment);
            Console.WriteLine("SALARY OF EMPLOYEE {0}", employeesalary);

        }

        public void IncreaseSalary(double amount)
        {
            employeesalary += amount;
            Console.WriteLine("SALARY AFTER INCREASING {0}", employeesalary);

        }
    }
    

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(76,"Rafia","Computer Science",90000);
            employee.employeeid = 76;
            employee.employeename = "RAFIA";
            employee.employeedepartment = "COMPUTER SCIENCE";
            employee.employeesalary = 900000;
            Console.WriteLine("EMPLOYEE DETAILS ");
           employee.DisplayEmployeeDetails();
            Console.WriteLine("employee salary increase ");
           employee.IncreaseSalary(10000);
            Console.WriteLine("UPDATED INFORMATION OF EMPLOYEE ");
            employee.DisplayEmployeeDetails();

        }
    }
}
