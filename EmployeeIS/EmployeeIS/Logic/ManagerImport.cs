using CsvHelper;
using EmployeeIS.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeIS.Logic
{
    public class ManagerImport
    {
        public ResultImportCorporation import(string _fileName)
        {
            ResultImportCorporation result = new ResultImportCorporation(); ;
            try
            {
                result.listCorporation = loadDataFromFile(_fileName);
            }
            catch (CsvHelperException che)
            {
                result.hasError = true;
                result.error = "Некорретный файл для загрузки.";// che.Message.ToString();
            }
            catch (Exception e)
            {
                result.hasError = true;
                result.error = e.Message.ToString();
            }

            return result;
        }

        private List<Corporation> loadDataFromFile(string _fileName)
        {
            List<Corporation> lstResult = new List<Corporation>();
            IEnumerable<Corporation> tempList;
            using (StreamReader reader = new StreamReader(_fileName))
            using (CsvReader csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                tempList = csv.GetRecords<Corporation>().ToList();
            }

            //IEnumerable enumerable = Enumerable.Range(1, 300);
            //List asList = enumerable.ToList();

            lstResult = tempList.ToList();
            return lstResult;
        }


    }
}
