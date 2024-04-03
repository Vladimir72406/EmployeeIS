using EmployeeIS.DataBase;
using EmployeeIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeIS.Logic
{
    class ManagerEmployee
    {

        IDataBase dba;
        public ManagerEmployee()
        {
            dba = InstanceDB.getInstance();
        }
        public Result addCorporation(Employee empl)
        {
            throw new Exception();
        }

        public Result updateEmployee(Employee empl)
        {
            throw new Exception();
        }

        public Employee getEmployeeById(int employee_id)
        {
            Employee employee = dba.getEmployeeById(employee_id);
            return employee;
        }

        public Result deleteEmployee(int employee_id)
        {
            throw new Exception();
        }

        public List<Employee> getEmployeeList(int corporation_id)
        {
            List<Employee> lst = dba.getListEmployee(corporation_id);
            return lst;
        }

        public Result saveEmployee(Employee employee)
        {
            Result resultSave = new Result();
            if (employee.employee_id > 0)
            {
                try
                {
                    resultSave = dba.updateEmployee(employee);
                }
                catch (Exception e)
                {
                    resultSave.hasError = true;
                    resultSave.error = e.Message.ToString();
                }
            }
            else
            {
                try
                {
                    resultSave = dba.insertEmployee(employee);
                }
                catch (Exception e)
                {
                    resultSave.hasError = true;
                    resultSave.error = e.Message.ToString();
                }
            }

            return resultSave;
        }
    }
}
