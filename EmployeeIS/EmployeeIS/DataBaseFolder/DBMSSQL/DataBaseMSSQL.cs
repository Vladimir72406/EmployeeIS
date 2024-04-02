using EmployeeIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeIS.DataBase.DBMSSQL
{
    public class DataBaseMSSQL : IDataBase
    {
        public Result CreateEmployee(Employee empl)
        {
            throw new NotImplementedException();
        }

        public Corporation getCorporationById(int corporation_id)
        {
            throw new NotImplementedException();
        }

        public Employee getEmployeeById(int employee_id)
        {
            throw new NotImplementedException();
        }

        public List<Corporation> getListCorporation()
        {
            //throw new NotImplementedException();
            List<Corporation> lst = new List<Corporation>();
            lst.Add(new Corporation(1, "Тест 1", ""));
            lst.Add(new Corporation(2, "Тест 2", ""));
            lst.Add(new Corporation(3, "Тест 3", ""));
            lst.Add(new Corporation(4, "Тест 4", ""));

            return lst;
        }

        public List<Employee> getListEmployee()
        {
            throw new NotImplementedException();
        }

        public Result updateEmployee(Employee empl)
        {
            throw new NotImplementedException();
        }
    }
}
