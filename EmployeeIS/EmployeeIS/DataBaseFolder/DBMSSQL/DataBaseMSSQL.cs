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




        public Employee getEmployeeById(int employee_id)
        {
            Employee empl = new Employee();
            if (employee_id == 1) empl = new Employee(1, "Мартирасян", "Евгений", "Сергеевич", new DateTime(1991, 12, 4));
            else if (employee_id == 2) empl = new Employee(2, "Иванов", "Кирилл", "Олегович", new DateTime(1992, 11, 2));
            else if (employee_id == 3) empl = new Employee(3, "Петров", "Роман", "Федорович", new DateTime(1993, 10, 12));
            else if (employee_id == 4) empl = new Employee(4, "Сидоров", "Алексей", "Петрович", new DateTime(1994, 09, 3));

            return empl;
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

        
        public Result insertEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        

        public Result updateEmployee(Employee empl)
        {
            throw new NotImplementedException();
        }
    }
}
