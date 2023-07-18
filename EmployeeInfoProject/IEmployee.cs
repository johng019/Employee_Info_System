using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeInfoProject
{
    //Basic Employee Info that can be implemented by muliple classes class in differnt ways
    public interface IEmployee
    {
        int EID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string Department { get; set; }

        void GetPayInfo(decimal basePay);
    }
}
