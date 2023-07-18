using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeInfoProject
{
    //Contains all employee information
     public class EmployeeConfidential
    {
        List<IEmployee> employee = new List<IEmployee>();

        public List<IEmployee> EmployeeList()
        {

            employee.Add(new Hourly { FirstName = "Bob", LastName = "Smith", Email = "B.Smith@company.com", Department = "Intern IT", EID = 201 });
            employee.Add(new Hourly { FirstName = "Carla", LastName = "Davis", Email = "C.Davis@company.com", Department = "Admin Assistant", EID = 202 });
            employee.Add(new Hourly { FirstName = "Terry", LastName = "Owens", Email = "T.Owens@company.com", Department = "IT specialist tech", EID = 203 });
            employee.Add(new Hourly { FirstName = "Tim", LastName = "Jones", Email = "Ti.Jones@company.com", Department = "Intern IT", EID = 204 });
            employee.Add(new Hourly { FirstName = "Cliff", LastName = "Adams", Email = "C.Adams@company.com", Department = "Intern IT", EID = 205 });
            employee.Add(new Hourly { FirstName = "Cindy", LastName = "Miller", Email = "C.Miller@company.com", Department = "Admin Assistant", EID = 206 });
            employee.Add(new Hourly { FirstName = "Terry", LastName = "Owens", Email = "T.Owens@company.com", Department = "IT specialist tech", EID = 207 });
            employee.Add(new Hourly { FirstName = "Tammy", LastName = "Jones", Email = "Ta.Jones@company.com", Department = "HR Specialist", EID = 208 });
            employee.Add(new Hourly { FirstName = "Bert", LastName = "williams", Email = "B.Williams@company.com", Department = "Intern QA Tester ", EID = 209 });

            employee.Add(new Salaried { FirstName = "Will", LastName = "Smith", Email = "W.Smith@company.com", Department = "Co Owner / CEO", EID = 101 });
            employee.Add(new Salaried { FirstName = "Miriam", LastName = "Davis", Email = "M.Davis@company.com", Department = "Co Owner / CTO", EID = 102 });
            employee.Add(new Salaried { FirstName = "Polly", LastName = "Jones", Email = "P.Jones@company.com", Department = "Co Owner / CIO", EID = 103 });
            employee.Add(new Salaried { FirstName = "Sam", LastName = "Young", Email = "S.Young@company.com", Department = "Finance / CFO", EID = 104 });
            employee.Add(new Salaried { FirstName = "Darrel", LastName = "Hammond", Email = "D.Hammond@company.com", Department = "Accounting ", EID = 105 });
            employee.Add(new Salaried { FirstName = "Mary Beth", LastName = "Davis", Email = "MB.Davis@company.com", Department = "Accounting ", EID = 106 });
            employee.Add(new Salaried { FirstName = "Patricia", LastName = "Myers", Email = "P.Meyers@company.com", Department = "Marketing ", EID = 107 });
            employee.Add(new Salaried { FirstName = "Steve", LastName = "Vick", Email = "S.Vick@company.com", Department = "Sales", EID = 108 });
            employee.Add(new Salaried { FirstName = "Sam", LastName = "Abrahams", Email = "S.Abrahams@company.com", Department = "Sales", EID = 109 });

            return  employee.GetRange(0,18);
        }
    }
}
