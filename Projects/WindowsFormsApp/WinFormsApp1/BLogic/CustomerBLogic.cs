using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    internal class CustomerBLogic : IDisposable
    {
        private readonly ApplicationDBWork _applicationDBWork;
        public CustomerBLogic()
        {
            _applicationDBWork = new ApplicationDBWork();
        }
        public void Add()
        {
            
        }

        public DataTable Retriveall(string cmd)
        {
            return _applicationDBWork.RetriveData(cmd);
        }

        public void Dispose()
        {
            
        }

        //public int Update()
        //{

        //}

        //public int Delete()
        //{

        //}

       
    }
}
