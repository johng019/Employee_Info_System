using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeInfoProject 
{
    public class PayInfo
    {
        /*This Class/ Method returns individual pay rate that matches an  employee ID passed in,
         back to the GetPay method of EmployeeInfo class.
         *Adds additional layer of abstraction*/

        public decimal MyPayInfo(int Eid)
        {
            decimal myPay;

            switch(Eid)
            {
                case 101:
                    myPay = 82000;
                    break;
              
                case 102:
                    myPay = 81000;
                    break;
                   
                case 103:
                    myPay = 80000;
                    break;

                case 104:
                    myPay = 78500;
                    break;

                case 105:
                    myPay = 65000;
                    break;

                case 106:
                    myPay = 64000;
                    break;

                case 107:
                    myPay = 60000;
                    break;

                case 108:
                    myPay = 58500;
                    break;

                case 109:
                    myPay = 5800;
                    break;

                case 201:
                    myPay = 18.00M;
                    break;

                case 202:
                    myPay = 19.50M;
                    break;

                case 203:
                    myPay = 22.75M;
                    break;

                case 204:
                    myPay = 18.00M;
                    break;

                case 205:
                    myPay = 18.00M;
                    break;

                case 206:
                    myPay = 19.00M;
                    break;

                case 207:
                    myPay = 22.55M;
                    break;

                case 208:
                    myPay = 21.00M;
                    break;

                case 209:
                    myPay = 18.00M;
                    break;

                default:
                    return 0;
                        
                
            }

            return myPay;
            
        }
    }
}
