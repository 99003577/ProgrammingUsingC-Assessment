using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    class DirectReport :Employee
    {
        public Employee ReportsTo { get; set; }
        public string ProjectCode { get; set; }

       // public DirectReport(Employee managerEmpObj,string pCode) : Employee(EmpID, eName,eLevel,eDoJ)
       public DirectReport(int EmpID, string eName, int eLevel, DateTime eDoJ, Employee managerEmpObj, string pCode)
        {
            ReportsTo = managerEmpObj;
            ProjectCode = pCode;
        }
    }
}
