using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class EmplyeeData
    {
        static void Main()
        {
       
        Console.Title = "Employee Data";

        string firstName = "First Name of emplyee";     //Declaring Strings
        string lastName = "Second Name of emplyee";     
        byte age = 25;                  
        char gender = 'f';                       // 'm' and 'f'depends from the gender.
        long personalID = 00000001;           // using long becouse of the more numbers
        uint uniqueNumber = 27560025u;       // unit not int, becouse of the positive values.

        Console.WriteLine(@"\n Employee Data: {0} {1}   
 Age: {2}  Gender: {3} Employee ID: {4}  Unique number: {5} ",firstName, lastName, age, gender, personalID, uniqueNumber);
    }
        }
    
}
