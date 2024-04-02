using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeIS.Models
{
    public class Corporation
    {
        int corporation_id;
        string corporation_name;
        string corporation_inn;

        public Corporation() { }

        public Corporation(int _corporation_id, string _corporation_name, string _corporation_inn) 
        {
            corporation_id = _corporation_id;
            corporation_name = _corporation_name;
            corporation_inn = _corporation_inn;
        }
    }
}
