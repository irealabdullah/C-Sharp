// ----------------
// Abstraction 
// ----------------

/*
0. Abstraction is a technique of showing necessary details and hiding unnecessary details from the user(other Classes)
1. Object ke necessary details/properties ko outside world/dosri class main show karwana is called Abstraction karwana and hide data is called Encapsulation
2. Hiding can be acheived using Private Access specifier
3. Abstaraction is hiding method implementation details For Exp: Console.WriteLine();is method ke peeche jo coding howi hai we dont neeed to know we just call it
4. User ko pata hoona chahiye ke what object does instead of How it does
*/
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    class Employee
    {
        public int EmpID;
        public string EmpName;
        public double GrossPay; //Interview time -> Basic Pay = 25k -- Part of Rent paid by Company = 5000 -- Convayence Allowance = 9k -- Total = 34k (this is gross pay)
        double TaxDeduction = 0.1; // 10%
        double NetSalary; // Gross pay - Tax = Net Salary

        public Employee(int EmpID,string EmpName,double EGrossPay)
        {
            this.EmpID = EmpID;
            this.EmpName = EmpName;
            this.GrossPay = EGrossPay;
        }

        void calculateSalary() // as we know it is private --> doosri classes ke liye iski implementation private hai
        {
            if(GrossPay>= 30000)
            {
                NetSalary = GrossPay - (TaxDeduction * GrossPay);
                Console.WriteLine("Your Net Salary After 10% Deduction is {0}",NetSalary);
            }
            else
            {
                Console.WriteLine("Your Net Salary withot tax deduction is {0}",GrossPay);
            }
        }
        
        public void showEmpDetails() 
        // Upper wale method ke implementation details ko hide karke iss method main rakhwa rahe hain
        // humne bus isse call karne ka ikhtayaar diya hai that is called abstraction
        { 
            Console.WriteLine("Employee ID is {0}", EmpID);
            Console.WriteLine("Employee Name is {0}",EmpName);
            this.calculateSalary();  //Iski implementation hidden hai aur iske medthod ko call kia. This is called Encapsulation
        }

        static void Main(string[] args)
        {
            Employee Ali = new Employee(10, "Arfat Tariq", 35000);
            Ali.showEmpDetails();
            Employee Abdullah = new Employee(11, "Abdullah Tariq", 23000);
            Abdullah.showEmpDetails();
            Employee Arfat = new Employee(12, "Ali Tariq", 29000);
            Arfat.showEmpDetails();
            Console.ReadLine();
        }
    }
}
//Abstraction can be acheived using Abstract classes, Abstract methods and interfaces as well