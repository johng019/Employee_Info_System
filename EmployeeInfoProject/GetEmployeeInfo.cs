using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeInfoProject
{ 
    //Creates and prints Employees Info of both Salary and Hourly status
    public class GetEmployeeInfo : EmployeeConfidential
    {
        EmployeeConfidential ec = new EmployeeConfidential();
        Hourly hy = new Hourly();
        Salaried sy = new Salaried();
        PayInfo myPayInfo = new PayInfo();

        //For printing the master list of employee information to the screen
        public void MyEmployeeList()
        {

            foreach (IEmployee emp in ec.EmployeeList())
            {
                //Calls GetPay method below that takes in (as a Parameter) a call to PayInfo class for specific info based on employee ID
                if (emp is Salaried)
                {
                    Console.WriteLine($"{emp.EID} {emp.FirstName} {emp.LastName}   Email: {emp.Email}  Department: {emp.Department}");
                    GetPayInfo(sy, myPayInfo.MyPayInfo(emp.EID));
                }
                else if (emp is Hourly)
                {
                    Console.WriteLine($"{emp.EID} {emp.FirstName} {emp.LastName}   Email: {emp.Email}  Department: {emp.Department}");
                    GetPayInfo(hy, myPayInfo.MyPayInfo(emp.EID));
                }
                Console.WriteLine(" ");
            }

        }

        /*This method uses the proper class Implimentation of Getpay() based on class - hourly/salaried  
        Takes in returned pay info from PayInfo class*/
        static void GetPayInfo(IEmployee emp, decimal basePay)
        {
            emp.GetPayInfo(basePay);
        }

       //For selecting an employees information by employee id
        public void MyEmployee(int eid)
        {

            foreach (IEmployee emp in ec.EmployeeList())
            {
                //Calls GetPay method below that takes in (as a Parameter) a call to PayInfo class for specific info based on employee ID

                if (emp.EID == eid)
                {
                    if (emp is Salaried)
                    {
                        Console.WriteLine("...................................................");
                        Console.WriteLine($"{emp.EID} {emp.FirstName} {emp.LastName}   Email: {emp.Email}  Department: {emp.Department}");
                        GetPayInfo(sy, myPayInfo.MyPayInfo(emp.EID));
                        Console.WriteLine("...................................................");
                    }

                    else if (emp is Hourly)
                    {
                        Console.WriteLine("...................................................");
                        Console.WriteLine($"{emp.EID} {emp.FirstName} {emp.LastName}   Email: {emp.Email}  Department: {emp.Department}");
                        GetPayInfo(hy, myPayInfo.MyPayInfo(emp.EID));
                        Console.WriteLine("...................................................");
                    }
                }
            }
            Console.WriteLine(" ");           
        }
    }
}
