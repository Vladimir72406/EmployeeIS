using EmployeeIS.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeIS.DataBase.DBMSSQL
{
    public class DataBaseMSSQL : IDataBase
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnectionEis"].ConnectionString;
        private SqlConnection connection;
    
        public void connect() {
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            
        }

        public void disconnect() 
        {
            try
            {
                connection.Close();
            }
            catch (Exception e)
            {

                throw new Exception(e.ToString());
            }
        }


        public List<Corporation> getListCorporation()
        {            
            List<Corporation> lstCorporation = new List<Corporation>();

            SqlCommand command = new SqlCommand();
            command.CommandText = "select corporation_id, corporation_name, corporation_inn from Corporation";
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lstCorporation.Add(new Corporation(reader));
                }
                reader.Close();
            }

            return lstCorporation;
        }

        public Corporation getCorporationById(int corporation_id)
        {
            Corporation corporation = new Corporation();

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT TOP 1 corporation_id, corporation_name, corporation_inn FROM Corporation WHERE corporation_id = @corporation_id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            SqlParameter corporationIdSqlParm = new SqlParameter("corporation_id", SqlDbType.Int);
            corporationIdSqlParm.Value = corporation_id;

            command.Parameters.Add(corporationIdSqlParm);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                corporation = new Corporation(reader);
                reader.Close();
            }

            return corporation;
        }

        public Result insertCorporation(Corporation newCorporation)
        {
            Result result = new Result();
            
            SqlCommand command = new SqlCommand();
            command.CommandText = "insert into Corporation ( corporation_name, corporation_inn ) " +
                "values(@corporation_name, @corporation_inn); SELECT SCOPE_IDENTITY()";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            SqlParameter corporation_name_sqlparm = new SqlParameter("corporation_name", SqlDbType.NVarChar);
            corporation_name_sqlparm.Value = newCorporation.corporation_name;
            command.Parameters.Add(corporation_name_sqlparm);

            SqlParameter corporation_inn_sqlparm = new SqlParameter("corporation_inn", SqlDbType.NVarChar);
            corporation_inn_sqlparm.Value = newCorporation.corporation_inn;
            command.Parameters.Add(corporation_inn_sqlparm);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    newCorporation.corporation_id = Convert.ToInt32(reader.GetValue(0));
                }
                reader.Close();
            }

            //return newCorporation;
            return result;
        }

        public Result updateCorporation(Corporation modifiedCorporation)
        {
            Result result = new Result();
            
            SqlCommand command = new SqlCommand();
            command.CommandText = "update Corporation " +
                "set corporation_name = @corporation_name, corporation_inn = @corporation_inn " +
                "where corporation_id = @corporation_id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            SqlParameter corporation_id_sqlparm = new SqlParameter("corporation_id", SqlDbType.Int);
            corporation_id_sqlparm.Value = modifiedCorporation.corporation_id;
            command.Parameters.Add(corporation_id_sqlparm);

            SqlParameter corporation_name_sqlparm = new SqlParameter("corporation_name", SqlDbType.NVarChar);
            corporation_name_sqlparm.Value = modifiedCorporation.corporation_name;
            command.Parameters.Add(corporation_name_sqlparm);

            SqlParameter corporation_inn_sqlparm = new SqlParameter("corporation_inn", SqlDbType.NVarChar);
            corporation_inn_sqlparm.Value = modifiedCorporation.corporation_inn;
            command.Parameters.Add(corporation_inn_sqlparm);

            command.ExecuteReader();

            return result;
        }

        public Result deleteCorporation(int corporation_id)
        {
            Result result = new Result();

            SqlCommand command = new SqlCommand();
            command.CommandText = "delete from Corporation where corporation_id = @corporation_id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            SqlParameter corporation_id_sqlparm = new SqlParameter("corporation_id", SqlDbType.Int);
            corporation_id_sqlparm.Value = corporation_id;
            command.Parameters.Add(corporation_id_sqlparm);

            command.ExecuteReader();

            return result;
        }
        //////////////////////////////////////

        public List<Employee> getListEmployeeByCorporationId(int corporation_id)
        {
            List<Employee> lstEmployee = new List<Employee>();

            SqlCommand command = new SqlCommand();
            command.CommandText = "" +
                "select employee_id, surname, name, middle_name, birthday, corporation_id, series, number " +
                "from employee where corporation_id = @corporation_id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            SqlParameter corporationIdSqlParm = new SqlParameter("corporation_id", SqlDbType.Int);
            corporationIdSqlParm.Value = corporation_id;

            command.Parameters.Add(corporationIdSqlParm);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lstEmployee.Add(new Employee(reader));                    
                }
                reader.Close();
            }

            return lstEmployee;
        }

        public List<Employee> getListEmployee()
        {
            List<Employee> lstEmployee = new List<Employee>();

            SqlCommand command = new SqlCommand();
            command.CommandText = "" +
                "select employee_id, surname, name, middle_name, birthday, corporation_id, series, number " +
                "from employee";
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lstEmployee.Add(new Employee(reader));
                }
                reader.Close();
            }

            return lstEmployee;
        }
        public Employee getEmployeeById(int employee_id)
        {
            Employee employee = new Employee();

            SqlCommand command = new SqlCommand();
            command.CommandText = "" +
                "select employee_id, surname, name, middle_name, birthday, corporation_id, series, number " +
                "from employee " +
                "where employee_id = @employee_id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            SqlParameter corporationIdSqlParm = new SqlParameter("employee_id", SqlDbType.Int);
            corporationIdSqlParm.Value = employee_id;
            command.Parameters.Add(corporationIdSqlParm);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    employee = new Employee(reader);
                }
                reader.Close();
            }

            return employee;
        }

        public Result insertEmployee(Employee employee)
        {
            Result resultInsert = new Result();

            SqlCommand command = new SqlCommand();
            command.CommandText = "insert into employee(surname, name, middle_name, birthday, corporation_id, series, number) " +
                "values(@surname, @name, @middle_name, @birthday, @corporation_id, @series, @number); " +
                "SELECT SCOPE_IDENTITY()";
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            
            //@employee_id, @surname, @name, @middle_name, @birthday, @corporation_id
            SqlParameter surname_sqlparm = new SqlParameter("surname", SqlDbType.NVarChar);
            surname_sqlparm.Value = employee.surname;
            command.Parameters.Add(surname_sqlparm);

            SqlParameter name_sqlparm = new SqlParameter("name", SqlDbType.NVarChar);
            name_sqlparm.Value = employee.name;
            command.Parameters.Add(name_sqlparm);

            SqlParameter middle_name_sqlparm = new SqlParameter("middle_name", SqlDbType.NVarChar);
            middle_name_sqlparm.Value = employee.middle_name;
            command.Parameters.Add(middle_name_sqlparm);

            SqlParameter birthDay_sqlparm = new SqlParameter("birthday", SqlDbType.DateTime);
            birthDay_sqlparm.Value = employee.birthday;
            command.Parameters.Add(birthDay_sqlparm);
            
            SqlParameter corporation_id_sqlparm = new SqlParameter("corporation_id", SqlDbType.Int);
            corporation_id_sqlparm.Value = employee.corporation_id;
            command.Parameters.Add(corporation_id_sqlparm);

            SqlParameter series_sqlparm = new SqlParameter("series", SqlDbType.NVarChar);
            series_sqlparm.Value = employee.series;
            command.Parameters.Add(series_sqlparm);

            SqlParameter number_sqlparm = new SqlParameter("number", SqlDbType.NVarChar);
            number_sqlparm.Value = employee.number;
            command.Parameters.Add(number_sqlparm);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    employee.employee_id = Convert.ToInt32(reader.GetValue(0));
                }
                reader.Close();
            }

            return resultInsert;
        }
        
        public Result updateEmployee(Employee employee)
        {
            Result resultInsert = new Result();

            SqlCommand command = new SqlCommand();
            command.CommandText = 
                "update employee " +
                "set surname = @surname, name = @name, middle_name = @middle_name, " +
                "       birthday = @birthday, corporation_id = corporation_id, series = @series, number = @number " +
                "where employee_id = @employee_id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            SqlParameter employee_id_sqlparm = new SqlParameter("employee_id", SqlDbType.Int);
            employee_id_sqlparm.Value = employee.employee_id;
            command.Parameters.Add(employee_id_sqlparm);

            SqlParameter surname_sqlparm = new SqlParameter("surname", SqlDbType.NVarChar);
            surname_sqlparm.Value = employee.surname;
            command.Parameters.Add(surname_sqlparm);

            SqlParameter name_sqlparm = new SqlParameter("name", SqlDbType.NVarChar);
            name_sqlparm.Value = employee.name;
            command.Parameters.Add(name_sqlparm);

            SqlParameter middle_name_sqlparm = new SqlParameter("middle_name", SqlDbType.NVarChar);
            middle_name_sqlparm.Value = employee.middle_name;
            command.Parameters.Add(middle_name_sqlparm);

            SqlParameter birthDay_sqlparm = new SqlParameter("birthday", SqlDbType.DateTime);
            birthDay_sqlparm.Value = employee.birthday;
            command.Parameters.Add(birthDay_sqlparm);

            SqlParameter corporation_id_sqlparm = new SqlParameter("corporation_id", SqlDbType.Int);
            corporation_id_sqlparm.Value = employee.corporation_id;
            command.Parameters.Add(corporation_id_sqlparm);

            SqlParameter series_sqlparm = new SqlParameter("series", SqlDbType.NVarChar);
            series_sqlparm.Value = employee.series;
            command.Parameters.Add(series_sqlparm);

            SqlParameter number_sqlparm = new SqlParameter("number", SqlDbType.NVarChar);
            number_sqlparm.Value = employee.number;
            command.Parameters.Add(number_sqlparm);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    employee.employee_id = Convert.ToInt32(reader.GetValue(0));
                }
                reader.Close();
            }

            return resultInsert;
        }

        public Result DeleteEmployee(int _employee_id)
        {
            Result result = new Result();

            SqlCommand command = new SqlCommand();
            command.CommandText = "delete from employee where employee_id = @employee_id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            SqlParameter employee_id_sqlparm = new SqlParameter("employee_id", SqlDbType.Int);
            employee_id_sqlparm.Value = _employee_id;
            command.Parameters.Add(employee_id_sqlparm);

            command.ExecuteReader();

            return result;
        }
    }
}
