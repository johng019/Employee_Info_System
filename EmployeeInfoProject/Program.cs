using System;
using System.Collections.Generic;

namespace EmployeeInfoProject
{
    /*
    * Author: Gary Johnston
    * Course : CEN 4370 CRN 26781
    * Professor: Jeho Park
    * Date: 3/26/22
    * Description: This program returns employee information
    * based on an employee id passed in. Then that information is 
    * presented to give the user the ability to cross reference and
    * validate the information.
    */
    class Program
    {
        static void Main(string[] args)
        {
            GetEmployeeInfo ei = new GetEmployeeInfo();
            int eid;

            //Setup
            Console.WriteLine("Company Inc. Has developed a secure method for HR to find employee information \n" +
                "from just using an employee id number (EID). The numbers range from 101 to 109 for salaried employees \n" +
                "and 201 to 209 for hourly employees. To test this new software, please enter a valid EID and see  \n" +
                "if the employee selected matches the master list.Please enter 0 and press ENTER to exit the simulation. \n" +
                "*After functionality is verified, the master list will be removed and the application will only return  \n" +
                "the selected empolyee information. Thank you for your participation in this test");

            Console.WriteLine("Please Enter a valid EID (101-109,201-209)");

            //Keep active until exit selection is made by user
            while (true)
            {
                {
                    try
                    {
                        eid = int.Parse(Console.ReadLine());
                        if (eid == 0)//User may wish to exit the application
                        {
                            break;
                        }
                        else if (eid > 100 && eid < 110 || eid > 200 && eid < 210)
                        { 
                            ei.MyEmployee(eid);
                            Console.WriteLine("Now see if the information matches the employees infomation in the master list. \n" +
                                "Press any key to print the master list.");
                            Console.ReadKey();
                            Console.WriteLine("...................................................");
                            ei.MyEmployeeList();
                            Console.WriteLine("Enter another EID or type 0 and hit ENTER to exit.");
                        }
                        else
                        {//For numbers not within range of employee ID.
                            Console.WriteLine("EID is not within range. Please try again");
                        }
                    }
                    catch (FormatException e)
                    {//For non numeric entries
                        Console.WriteLine("Invalid format. Please try again");
                    }
                }
            }
           
        }
    }
}
