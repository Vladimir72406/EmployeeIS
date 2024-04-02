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

        public Result deleteCorporation(int corporation_id)
        {
            throw new NotImplementedException();
        }

        public Corporation getCorporationById(int corporation_id)
        {
            //throw new NotImplementedException();
            Corporation corp = new Corporation();
            if(corporation_id == 1) corp = new Corporation(1, "Тест 1", "");
            else if (corporation_id == 2) corp = new Corporation(2, "Тест 2", "");
            else if (corporation_id == 3) corp = new Corporation(3, "Тест 3", "");
            else if (corporation_id == 4) corp = new Corporation(4, "Тест 4", "");

            return corp;
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

        public Result insertCorporation(Corporation newCorporation)
        {
            throw new NotImplementedException();
        }

        public Result updateCorporation(Corporation modifiedCorporation)
        {
            throw new NotImplementedException();
        }

        public Result updateEmployee(Employee empl)
        {
            throw new NotImplementedException();
        }
    }
}
