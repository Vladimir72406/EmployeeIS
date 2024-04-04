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
    public class ManagerExport
    {
        public Result export(List<Corporation> _listCorporation, string _dirrectoryForCreateFile)
        {
            Result result = new Result();
            try
            {
                string newFileName = getNameForNewFile(_dirrectoryForCreateFile);
                createFile(_dirrectoryForCreateFile, newFileName);
                exportDataToFile(_listCorporation, _dirrectoryForCreateFile + "\\" + newFileName);

            }
            catch (Exception e)
            {
                result.hasError = true;
                result.error = e.Message.ToString();
            }

            return result;            
        }

        private string getNameForNewFile(string _dirrectoryForCreateFile)
        {
            string newFileName = "report_" + DateTime.Now.ToString("yyyy.MM.dd_HH.mm.ss");
            int tryCount = 0;

            while (File.Exists(_dirrectoryForCreateFile + "\\" + newFileName + "_" + tryCount.ToString() + ".csv") && tryCount >= 100)
            {
                tryCount++;
            }

            if (tryCount == 100)
                throw new Exception("Не получилось определить имя для файла.");

            string fullName = newFileName + "_" + tryCount.ToString() + ".csv";
            return fullName;
        }

        private void createFile(string _dirrectoryForCreateFile, string _fileName)
        {
            try
            {
                var resultCreate = File.Create(_dirrectoryForCreateFile + "\\" + _fileName);
                resultCreate.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private void exportDataToFile(List<Corporation> _listCorporation, string _fileForRecord)
        {
            using (var writer = new StreamWriter(_fileForRecord))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                foreach (var item in _listCorporation)                
                {
                    var enumerable = new[] { item };
                    csv.WriteRecords(enumerable);

                }
            }

                
        }
    }
}
