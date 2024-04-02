using EmployeeIS.DataBase.DBMSSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeIS.DataBase
{
    public class InstanceDB
    {
        private static IDataBase dba;

        public static IDataBase getInstance()
        {
            if (dba == null)
            {
                dba = new DataBaseMSSQL();
            }

            return dba;
        }
    }
}