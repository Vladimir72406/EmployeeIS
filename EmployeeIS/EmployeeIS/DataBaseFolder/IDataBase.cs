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
        void connect();
        void disconnect();


        //
        Corporation getCorporationById(int corporation_id);
        List<Corporation> getListCorporation();
        Result insertCorporation(Corporation newCorporation);
        Result updateCorporation(Corporation modifiedCorporation);
        Result deleteCorporation(int corporation_id);

        //
        List<Employee> getListEmployeeByCorporationId(int corporation_id);
        List<Employee> getListEmployee();
        Employee getEmployeeById(int employee_id);        
        Result insertEmployee(Employee employee);
        Result updateEmployee(Employee empl);
        Result DeleteEmployee(int employee_id);

        //
        List<Address> getListAddressByCorporationID(int corporation_id);
        Address getAddressByID(int address_id);
        Result insertAddress(Address newAddress);
        Result updateAddress(Address modifiedAddress);
        Result deleteAddress(int address_id);
    }
}
