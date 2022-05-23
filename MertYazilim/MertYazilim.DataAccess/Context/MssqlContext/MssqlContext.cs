using MertYazilim.DataAccess.Context.Abstract;
using MertYazilim.Entities.Concrete.Log;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MertYazilim.DataAccess.Context.MssqlContext
{
    public class MssqlContext: IDatabase
    {
        private SqlConnection ConnectionString { get; set; }

        public MssqlContext()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json").Build();
            var connectionString = configuration.GetConnectionString("MsSqlContext");
            ConnectionString = new SqlConnection(connectionString);
            OpenConnection();
        }

        public void OpenConnection()
        {
            if (ConnectionString.State == ConnectionState.Closed)
            {
                ConnectionString.Open();
            }
        }

        public List<Log> GetAll()
        {
            string command = $"Select * from Logs";
            SqlCommand sqlCommand = new SqlCommand(command, ConnectionString);
            DbDataReader dbDataReader = sqlCommand.ExecuteReader();

            List<Log> logs = new List<Log>();

            while (dbDataReader.Read())
            {
                Log log = new Log
                {
                    Id = Convert.ToInt32(dbDataReader["Id"]),
                    Method = dbDataReader["Method"].ToString(),
                    Path = dbDataReader["Path"].ToString(),
                    Query = dbDataReader["Query"].ToString(),
                    CreatedTime = Convert.ToDateTime(dbDataReader["CreatedTime"]),
                };
                logs.Add(log);
            }

            ConnectionString.Close();
            return logs;
        }

        public void Add(Log log)
        {
            string command = $"INSERT INTO Logs (Method, Path, Query, CreatedTime) VALUES(@p1, @p2, @p3, @p4)";
            SqlCommand sqlCommand = new SqlCommand(command, ConnectionString);
            sqlCommand.Parameters.AddWithValue("@p1", log.Method);
            sqlCommand.Parameters.AddWithValue("@p2", log.Path);
            sqlCommand.Parameters.AddWithValue("@p3", log.Query);
            sqlCommand.Parameters.AddWithValue("@p4", log.CreatedTime);

            sqlCommand.ExecuteNonQuery();

            ConnectionString.Close();
        }
    }
}
