using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rheal_day3_employee_project
{
    class EmployeeProgram
    {
        private EmployeeCollection EList = new EmployeeCollection();

        //function to display main menu
        public void mainMenu()
        {
            Console.WriteLine("===============================================================");
            Console.WriteLine("Employee Program");
            Console.WriteLine("===============================================================");
            Console.WriteLine("1. List All Employees");
            Console.WriteLine("2. List All Employees For A Specific Department");
            Console.WriteLine("3. Add New Employee");
            Console.WriteLine("4. Delete An Employee");
            Console.WriteLine("5. Update Salary of Employee");
            Console.WriteLine("6. Find 2nd Max Salaried Employee for Each Department");
            Console.WriteLine();
            Console.WriteLine("X: Close");
            Console.WriteLine("===============================================================");
        }

        //function to display footer message
        public void footerMessage()
        {
            Console.WriteLine();
            Console.WriteLine("press any key to go back...");
            Console.ReadKey();
            Console.Clear();
        }

        //function to display error message
        public void errorMessage()
        {
            Console.WriteLine("ERROR!");
            Console.WriteLine("Something Went Wrong!");
            Console.WriteLine();
            Console.WriteLine("Press any key to go back....");
            Console.ReadKey();
            Console.Clear();
        }

        //main function containing switch
        public void start()
        {
            bool quit = false;

            while (!quit)
            {
                string sw;
                mainMenu();
                sw = Console.ReadLine();
                Console.Clear();
                switch (sw)
                {
                    //display all employees
                    case "1":
                        getAllEmployees();
                        footerMessage();
                        break;

                    //display Employees based on Department
                    case "2":
                        try
                        {
                            Console.WriteLine("Enter Department Name:");
                            string dept = Console.ReadLine();
                            Console.WriteLine();
                            getEmployeesByDepartment(dept);
                            footerMessage();
                        }
                        catch (Exception e)
                        {
                            errorMessage();
                        }
                        
                        break;

                    //Add New Employee
                    case "3":
                        try
                        {
                            addNewEmployee();
                            footerMessage();
                        }
                        catch (Exception e)
                        {
                            errorMessage();
                        }
                        
                        break;

                    //delete employee based on emp no.
                    case "4":
                        try
                        {
                            Console.WriteLine("Enter EmployeeID to delete");
                            deleteEmployee(Convert.ToInt32(Console.ReadLine()));
                            footerMessage();
                        }
                        catch (Exception e)
                        {
                            errorMessage();
                        }
                        
                        break;

                    //update salary of specific employee
                    case "5":
                        try
                        {
                            Console.WriteLine("Enter Employee Details to update");
                            Console.WriteLine("EmployeeID");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Employee Salary");
                            int salary = Convert.ToInt32(Console.ReadLine());
                            updateSalary(id, salary);
                            footerMessage();
                        }
                        catch (Exception e)
                        {
                            errorMessage();
                        }                      
                        break;

                    //find second max salaried employee
                    case "6":
                        secondMaxSalary();
                        footerMessage();
                        break;

                    case "x":
                    case "X":
                        quit = true;
                        break;

                    default:
                        Console.WriteLine("Please give valid input.");
                        Console.WriteLine("press any key to go back...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }

        //method for printing resulting data
        public void printResult(IEnumerable<Employee> result)
        {
            Console.WriteLine("ID\t\tName\t\tDepartment\tSalary");
            foreach (var item in result)
            {
                Console.WriteLine($"{item.EmployeeId}\t\t{item.EmployeeName}\t\t{item.EmployeeDepartment}\t\t{item.EmployeeSalary}\t\t");
            }
        }
        //method for printing resulting data

        public void printResult(Employee emp)
        {
            Console.WriteLine("ID\t\tName\t\tDepartment\tSalary");
            Console.WriteLine($"{emp.EmployeeId}\t\t{emp.EmployeeName}\t\t{emp.EmployeeDepartment}\t\t{emp.EmployeeSalary}\t\t");
        }

        //get all employees
        public void getAllEmployees()
        {
            var result = from emp in EList
                         orderby emp.EmployeeId
                         select new Employee()
                         {
                             EmployeeDepartment = emp.EmployeeDepartment,
                             EmployeeId = emp.EmployeeId,
                             EmployeeName = emp.EmployeeName,
                             EmployeeSalary = emp.EmployeeSalary,
                         };

            printResult(result);
        }

        //get employees based on department
        public void getEmployeesByDepartment(string dept)
        {
            var result = EList.Where(e => e.EmployeeDepartment.Equals(dept));

            printResult(result);
        }

        //add new employee
        public void addNewEmployee()
        {
            Employee emp = new Employee();
            Console.WriteLine("Enter Employee ID");
            emp.EmployeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            emp.EmployeeName = Console.ReadLine();
            Console.WriteLine("Enter Employee Department");
            emp.EmployeeDepartment = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            emp.EmployeeSalary = Convert.ToInt32(Console.ReadLine());
            EList.Add(emp);
        }

        //delete employee based on EmployeeId
        public void deleteEmployee(int id)
        {
            Employee emp = EList.Where(e => e.EmployeeId.Equals(id)).First();
            EList.Remove(emp);
        }

        //update Salary of specific employee
        public void updateSalary(int id, int salary)
        {
            Employee emp = EList.Where(e => e.EmployeeId.Equals(id)).First();
            EList.Remove(emp);
            emp.EmployeeSalary = salary;
            EList.Add(emp);

        }

        //find second max salaried employee
        public void secondMaxSalary()
        {
            var result = EList.OrderByDescending(e => e.EmployeeSalary).Skip(1).First();
            Console.WriteLine("2nd Max salaried person is:");
            printResult(result);
        }
    }
}

