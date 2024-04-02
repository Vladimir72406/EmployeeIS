using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeIS.Models
{
    public class Result
    {
        bool isError = false;
        string error;

        public Result() { }

        public Result(bool _isError, string _error)
        {
            isError = _isError;
            error = _error;
        }
    }

    
}
