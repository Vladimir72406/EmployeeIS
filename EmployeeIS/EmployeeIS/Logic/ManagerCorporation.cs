using EmployeeIS.DataBase;
using EmployeeIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeIS.Logic
{
    public class ManagerCorporation
    {
        IDataBase dba;
        public ManagerCorporation()
        {
            dba = InstanceDB.getInstance();
        }
        public Result saveCorporation(Corporation corporation)
        {
            Result result = new Result();
            if (corporation.corporation_id > 0)
            {
                try
                {                    
                    result = dba.updateCorporation(corporation);
                }
                catch (Exception e)
                {
                    result.hasError = true;
                    result.error = e.Message.ToString();
                }
            }
            else
            {
                try
                {
                    result = dba.insertCorporation(corporation);
                }
                catch (Exception e)
                {
                    result.hasError = true;
                    result.error = e.Message.ToString();
                }
            }

            return result;
        }

        public Corporation getCorporationById(int corporation_id)
        {
            return dba.getCorporationById(corporation_id);
        }

        public Result deleteCorporation(int corporation_id)
        {
            Result result = new Result();
            try
            {
                result = dba.deleteCorporation(corporation_id);
            }
            catch (Exception e)
            {
                result.error = e.Message.ToString();
                result.hasError = true;
            }
            return result;
        }

        public List<Corporation> getCorporationList()
        {
            List<Corporation> lst = dba.getListCorporation();
            return lst;
        }
    }
}
