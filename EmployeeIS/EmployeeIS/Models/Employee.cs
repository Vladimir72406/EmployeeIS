using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeIS.Models
{
    public class Employee
    {
        [DisplayName("ID")]
        public int employee_id { get; set; }

        [DisplayName("Фамилия")]
        public string surname { get; set; }

        [DisplayName("Имя")]
        public string name { get; set; }

        [DisplayName("Отчество")]
        public string middle_name { get; set; }

        [DisplayName("Дата рождения")]
        public DateTime birthday { get; set; }

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
