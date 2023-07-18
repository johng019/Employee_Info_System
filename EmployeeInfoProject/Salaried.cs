using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeInfoProject
{
    //Impliments IEmployee properties and method for Salaried employees
    public class Salaried : IEmployee
    {
        public int EID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }

        public void GetPayInfo(decimal basePay)
        {
            Console.WriteLine("Employees salary is $ " + basePay + " per Year. ");
        }
    }
}
