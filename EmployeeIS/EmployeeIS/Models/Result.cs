using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeIS.Models
{
    public class Result
    {
        public bool hasError = false;
        public string error;

        public Result() { }

        public Result(bool _hasError, string _error)
        {
            hasError = _hasError;
            error = _error;
        }
    }

    
}
