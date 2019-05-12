using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Data_Access_Layer
{
    class DB_Access
    {
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        public DB_Access()
        {
            // Need to get Server name from datbase for the code below!
            connection.DataSource = ;
            connection.InitialCatalog = ;
            connection.IntegratedSecurity = ;
        }

        public DataSet ReadData(string _tblName)   // Reading data from the database. Can be used for user login for user ID and User ranking (Adjust code to return these values)
        {
            DataSet rawData = new DataSet();
            SqlConnection conn = new SqlConnection(connection.ToString());
            string qry = string.Format("SELECT * FROM {0}", _tblName);

            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(qry, conn);
                adapter.FillSchema(rawData, SchemaType.Source, _tblName);
                adapter.Fill(rawData,_tblName);
            }
            catch (SqlException se)
            {
                MessageBox.Show(string.Format("Error : {0}", se.Message));
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

        public void InsertDecrptMsg(List<string> _DecryptMsg)  // Insert decrypted message to database // using this method to prevent SQL injection (More secure)
        {
            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand("UpdateDB_DecryptMsg", conn))   // Not sure if the first paramater is correct?
                    {
                        command.Parameters.AddWithValue("@DecryptedMessage", _DecryptMsg);       // Mirror the datafield (column) of the database's name in place of the "@DecryptedMessage" eg) Instead of "@DecryptedMessage", in the database it is "@DecryptMsg" so you need to change that to "@DecryptMsg" to match database's field for the decypted messages
                        command.ExecuteNonQuery();
                        MessageBox.Show("Message was successfully decrypted and stored.");
                    }
                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
                
            }
        }
    }
}
