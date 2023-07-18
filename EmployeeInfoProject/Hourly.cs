using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeInfoProject
{
    //Impliments IEmployee properties and method for hourly employees
    public class Hourly : IEmployee
    {
        public int EID { get; set; }
        public string FirstName { get ; set ; }
        public string LastName { get ; set; }
        public string Email { get; set; }
        public string Department { get; set; }

        public void GetPayInfo(decimal basePay)
        {
            Console.WriteLine("Employees pay rate is $ " + basePay + " per hour.");
        }
    }
}
