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
            Employee empl = new Employee();
            if (employee_id == 1) empl = new Employee(1, "Мартирасян", "Евгений", "Сергеевич", new DateTime(1991, 12, 4));
            else if (employee_id == 2) empl = new Employee(2, "Иванов", "Кирилл", "Олегович", new DateTime(1992, 11, 2));
            else if (employee_id == 3) empl = new Employee(3, "Петров", "Роман", "Федорович", new DateTime(1993, 10, 12));
            else if (employee_id == 4) empl = new Employee(4, "Сидоров", "Алексей", "Петрович", new DateTime(1994, 09, 3));

            return empl;
        }

        public List<Corporation> getListCorporation()
        {            
            List<Corporation> lst = new List<Corporation>();
            lst.Add(new Corporation(1, "Тест 1", ""));
            lst.Add(new Corporation(2, "Тест 2", ""));
            lst.Add(new Corporation(3, "Тест 3", ""));
            lst.Add(new Corporation(4, "Тест 4", ""));

            return lst;
        }

        public List<Employee> getListEmployee(int corporation_id)
        {
            List<Employee> lst = new List<Employee>();

            lst.Add(new Employee(1, "Мартирасян", "Евгений", "Сергеевич", new DateTime(1991, 12, 4)));
            lst.Add(new Employee(2, "Иванов", "Кирилл", "Олегович", new DateTime(1992, 11, 2)));
            lst.Add(new Employee(3, "Петров", "Роман", "Федорович", new DateTime(1993, 10, 12)));
            lst.Add(new Employee(4, "Сидоров", "Алексей", "Петрович", new DateTime(1994, 09, 3)));

            return lst;
        }

        public Result insertCorporation(Corporation newCorporation)
        {
            throw new NotImplementedException();
        }

        public Result insertEmployee(Employee employee)
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
