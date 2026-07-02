using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Entities.DBWork
{
    public class ApplicationDBWork
    {
        public readonly SqlCommand _sqlCommand;
        public readonly SqlConnection _sqlConnection;
        string connectionstring = "Data Source=.;Initial Catalog=NORTHWND;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public readonly SqlDataAdapter SqlDataAdapter;
        public SqlDataReader sqlDataReader = null;


        public ApplicationDBWork()
        {
            _sqlConnection = new SqlConnection(connectionstring);
            _sqlCommand = new SqlCommand(connectionstring);
            SqlDataAdapter = new SqlDataAdapter();

            _sqlCommand.Connection = _sqlConnection;
        }

        public int intoData(string obj)
        {
           
            try
            {
                _sqlCommand.CommandText = obj;
                _sqlConnection.Open();
                int result = _sqlCommand.ExecuteNonQuery();
                _sqlConnection.Close();
                _sqlConnection.DisposeAsync();
                return result;
            }catch (Exception ex)
            {
                return 0;
            }
        }

        public object Scalar(string obj)
        {
            try
            {
                _sqlCommand.CommandText = obj;
                _sqlConnection.Open();
                object result = _sqlCommand.ExecuteScalar();
                _sqlConnection.Close();
                _sqlConnection.DisposeAsync();
                return result;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        public DataTable RetriveData(string obj)
        {
            DataTable dataTable = new DataTable();
            try
            {
                _sqlCommand.CommandText = obj;
                
                _sqlConnection.Open();
                
                sqlDataReader = _sqlCommand.ExecuteReader();
                dataTable.Load(sqlDataReader);
                _sqlConnection.Close();
                sqlDataReader.DisposeAsync();
                return dataTable;
            }
            catch (Exception ex)
            {
                _sqlConnection.Close();
                return null;
            }
        }

        public void UpdateData(DataSet obj ,string tableName)
        {
            SqlDataAdapter.Update(obj,tableName);
        }
    }
}
