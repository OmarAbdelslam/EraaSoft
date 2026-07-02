using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Entities;
using WinFormsApp1.Entities.DBWork;

namespace WinFormsApp1.BLogic
{
    internal class EmployeeLogic
    {
        public DataTable employees()
        {
            string cmd = "Select * From Employees";
            ApplicationDBWork applicationDBWork = new ApplicationDBWork();
            return applicationDBWork.RetriveData(cmd);
        }
    }
}
