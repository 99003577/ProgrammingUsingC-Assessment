using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    class Manager 
    {
        public List<Employee> DirectReports { get; set; }
        public string CostCode { get; set; }

       // public Manager(List<Employee> drEmployeesLst, string cCode) : Employee (int empID, string eName, int eLevel, DateTime eDoJ)
           public Manager(int empID, string eName, int eLevel, DateTime eDoJ, List<Employee> drEmployeesLst, string cCode)

        {    DirectReports = drEmployeesLst;
            CostCode = cCode;

        }

        public List<string> GetMyReports()
        {
            return DirectReports.Select(x => x.EmpName).ToList();
        }

    }
}
