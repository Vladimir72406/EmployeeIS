using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeIS.Models
{
    public class Corporation
    {
        [DisplayName("ID")]
        public int corporation_id { get; set; }

        [DisplayName("Наименование компании")]
        public string corporation_name { get; set; }

        [DisplayName("ИНН компании")]
        public string corporation_inn { get; set; }

        public Corporation() { }

        public Corporation(int _corporation_id, string _corporation_name, string _corporation_inn) 
        {
            corporation_id = _corporation_id;
            corporation_name = _corporation_name;
            corporation_inn = _corporation_inn;
        }
    }
}
