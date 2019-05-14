using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Data_Access_Layer
{
    public class DB_Access
    {
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        public DB_Access()
        {
            // Need to get Server name from datbase for the code below!
            connection.DataSource = ;
            connection.InitialCatalog = ;
            connection.IntegratedSecurity = ;
        }

        public DataSet ReadData(string _tblName)   // Reading data from the database for user login details.
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

        public void AddUser(string _UName, string _USurname, int _UAge, int _URank, string _Username, string _Password)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());
            
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("ProcAddUser", conn); 
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", _UName);
                command.Parameters.AddWithValue("@Age", _UAge);
                command.Parameters.AddWithValue("@Rank", _URank);
                command.Parameters.AddWithValue("@Surname", _USurname);
                command.Parameters.AddWithValue("@Username", _Username);
                command.Parameters.AddWithValue("@Password", _Password);

                int Changed = 0;
                Changed = command.ExecuteNonQuery();
                if (Changed > 0)
                {
                    MessageBox.Show("Successfully added user to the system.", "Add user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User was not added.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public void RemoveUser(int _UserID) // Remove using the Primary key (UserID) which removes all the data associated with that primary key
        {
            SqlConnection conn = new SqlConnection(connection.ToString());
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("ProcRemoveUser", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", _UserID);

                int Changed = 0;
                Changed = command.ExecuteNonQuery();
                if (Changed > 0)
                {
                    MessageBox.Show("Successfully removed user from the system.", "Removed user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User was not removed.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public void UpdateUser(int _IDNum, string _UName, string _USurname, int _UAge, int _URank, string _Username, string _Password) 
        {
            SqlConnection conn = new SqlConnection(connection.ToString());
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("ProcUpdateUser", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", _IDNum);
                command.Parameters.AddWithValue("@Name", _UName);
                command.Parameters.AddWithValue("@Age", _UAge);
                command.Parameters.AddWithValue("@Rank", _URank);
                command.Parameters.AddWithValue("@Surname", _USurname);
                command.Parameters.AddWithValue("@Username", _Username);
                command.Parameters.AddWithValue("@Password", _Password);

                int Changed = 0;
                Changed = command.ExecuteNonQuery();
                if (Changed > 0)
                {
                    MessageBox.Show("Successfully updated user in the system.", "Updated user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User was not updated.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
