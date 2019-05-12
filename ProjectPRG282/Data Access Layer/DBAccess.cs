using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
//using System.Windows.Forms;

namespace Data_Access_Layer
{
    class DBAccess
    {
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();

        public DBAccess()
        {
            connection.DataSource = @"";
            connection.InitialCatalog = "";
            connection.IntegratedSecurity = true;
        }

        public DataSet Readdata(string tablename)
        {
            DataSet rawData = new DataSet();
            SqlConnection conn = new SqlConnection(connection.ToString());
            string qry = string.Format("SELECT * FROM {0}", tablename);
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                adapter.FillSchema(rawData, SchemaType.Source, tablename);
                adapter.Fill(rawData, tablename);

            }
            catch (SqlException se)
            {
                //MessageBox.Show(se.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return rawData;
        }

    }
}
