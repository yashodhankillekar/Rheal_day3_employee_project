using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rheal_day3_employee_project
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeSalary { get; set; }
        public string EmployeeDepartment { get; set; }

    }

    public class EmployeeCollection : List<Employee>
    {
        public EmployeeCollection()
        {
            Add(new Employee() { EmployeeId = 01, EmployeeDepartment = "IT", EmployeeName = "Yashodhan", EmployeeSalary = 25000 });
            Add(new Employee() { EmployeeId = 02, EmployeeDepartment = "IT", EmployeeName = "kakashi", EmployeeSalary = 30000 });
            Add(new Employee() { EmployeeId = 03, EmployeeDepartment = "IT", EmployeeName = "Naruto", EmployeeSalary = 25000 });
            Add(new Employee() { EmployeeId = 04, EmployeeDepartment = "IT", EmployeeName = "Ram", EmployeeSalary = 20000 });
            Add(new Employee() { EmployeeId = 05, EmployeeDepartment = "Acc", EmployeeName = "Shyam", EmployeeSalary = 20000 });
            Add(new Employee() { EmployeeId = 06, EmployeeDepartment = "Acc", EmployeeName = "Paul", EmployeeSalary = 20000 });
            Add(new Employee() { EmployeeId = 07, EmployeeDepartment = "Acc", EmployeeName = "Vin", EmployeeSalary = 18000 });
            Add(new Employee() { EmployeeId = 08, EmployeeDepartment = "Acc", EmployeeName = "Aniket", EmployeeSalary = 22000 });
            Add(new Employee() { EmployeeId = 09, EmployeeDepartment = "HR", EmployeeName = "Bhavesh", EmployeeSalary = 26000 });
            Add(new Employee() { EmployeeId = 10, EmployeeDepartment = "HR", EmployeeName = "Bheem", EmployeeSalary = 28000 });
            Add(new Employee() { EmployeeId = 11, EmployeeDepartment = "HR", EmployeeName = "Yogesh", EmployeeSalary = 23000 });
            Add(new Employee() { EmployeeId = 12, EmployeeDepartment = "HR", EmployeeName = "Gaurav", EmployeeSalary = 26000 });


        }
    }

}
