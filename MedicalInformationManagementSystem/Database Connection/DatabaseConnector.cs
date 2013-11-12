using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthInformaticSystem
{
    class DatabaseConnector
    {
        private SqlConnection conn;
        
        public DatabaseConnector()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>the ms sql connection</returns>
        public SqlConnection getConnection()
        {
            if (conn == null)
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "bang.Giberson"; // <-- change this to your ms sql server
                builder.InitialCatalog = "Giberson";
                builder.IntegratedSecurity = true;

                conn = new SqlConnection("Data Source=BANG\\;Initial Catalog=Giberson;Integrated Security=True");
            }
            return conn;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="SqlStatement">sql statement</param>
        /// <param name="parameters">dictionary with the "@key" and it "values"</param>
        /// <returns>sql result in datatable format</returns>
        public DataTable getData(string SqlStatement, Dictionary<String, String> parameters)
        {
            DataTable table = new DataTable();
            
            SqlConnection conn = getConnection();                

            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = SqlStatement;
            foreach(KeyValuePair<String, String> p in parameters)
            {
                cmd.Parameters.Add(new SqlParameter(p.Key, p.Value));
            }
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                table.Load(reader);
            }

            conn.Close();
            return table;
        }
    }
}
