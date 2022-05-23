using MertYazilim.DataAccess.Context.Abstract;
using MertYazilim.Entities.Concrete.Log;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MertYazilim.DataAccess.Context.NpgsqlContext
{
    public class NpgsqlContext: IDatabase
    {
        private NpgsqlConnection ConnectionString { get; set; }
        public NpgsqlContext()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json").Build();
            var connectionString = configuration.GetConnectionString("NpgSqlContext");
            ConnectionString = new NpgsqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (ConnectionString.State == ConnectionState.Closed)
            {
                ConnectionString.Open();
            }
        }

        public void Add(Log log)
        {
            OpenConnection();

            string command = $"INSERT INTO public.\"Logs\" (\"Method\", \"Path\", \"Query\", \"CreatedTime\") VALUES (@p1, @p2, @p3, @p4)";

            NpgsqlCommand sqlCommand = new NpgsqlCommand(command, ConnectionString);
            sqlCommand.Parameters.AddWithValue("@p1", log.Method);
            sqlCommand.Parameters.AddWithValue("@p2", log.Path);
            sqlCommand.Parameters.AddWithValue("@p3", log.Query);
            sqlCommand.Parameters.AddWithValue("@p4", log.CreatedTime);

            sqlCommand.ExecuteNonQuery();

            ConnectionString.Close();
        }

        public List<Log> GetAll()
        {
            OpenConnection();

            string command = $"Select * from public.\"Logs\"";
            NpgsqlCommand sqlCommand = new NpgsqlCommand(command, ConnectionString);
            NpgsqlDataReader dr = sqlCommand.ExecuteReader();

            List<Log> logs = new List<Log>();

            while (dr.Read())
            {
                Log log = new Log
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Method = dr["Method"].ToString(),
                    Path = dr["Path"].ToString(),
                    Query = dr["Query"].ToString(),
                    CreatedTime = Convert.ToDateTime(dr["CreatedTime"]),
                };
                logs.Add(log);
            }

            ConnectionString.Close();
            return logs;
        }
    }
}
