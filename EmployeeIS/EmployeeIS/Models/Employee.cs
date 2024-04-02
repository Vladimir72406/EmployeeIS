using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeIS.Models
{
    public class Employee
    {
        int employee_id;
        string surname;
        string name;
        string middle_name;
        DateTime birthday;

        public Employee() { }

        public Employee(int _employee_id, string _surname, string _name, string _middle_name, DateTime _birthday) 
        {
            employee_id = _employee_id;
            surname = _surname;
            name = _name;
            middle_name = _middle_name;
            birthday = _birthday;
        }
    }
}
