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
            throw new NotImplementedException();
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
