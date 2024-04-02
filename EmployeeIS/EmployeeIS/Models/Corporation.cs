using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeIS.Models
{
    public class Corporation
    {
        public int corporation_id { get; set; }
        public string corporation_name { get; set; }
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
