using EmployeeIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeIS.DataBase
{
    public interface IDataBase
    {
        Corporation getCorporationById(int corporation_id);

        List<Corporation> getListCorporation();

        Result insertCorporation(Corporation newCorporation);
        Result updateCorporation(Corporation modifiedCorporation);

        Result deleteCorporation(int corporation_id);

        Employee getEmployeeById(int employee_id);

        List<Employee> getListEmployee();

        Result updateEmployee(Employee empl);

        Result CreateEmployee(Employee empl);

        


    }
}
