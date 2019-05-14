using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data_Access_Layer;
using System.Data;


namespace Bussiness__Layer
{
    public class Communications
    {
        private int idnumber;
        private int messageid;
        private int duration;
        private string message;

        DB_Access dba = new DB_Access();

        public int Idnumber { get => idnumber; set => idnumber = value; }
        public int Messageid { get => messageid; set => messageid = value; }
        public int Duration { get => duration; set => duration = value; }
        public string Message { get => message; set => message = value; }

        public Communications(int c_idnumber,int c_messageid,int c_duration,string c_message)
        {
            this.idnumber = c_idnumber;
            this.messageid = c_messageid;
            this.duration = c_duration;
            this.message = c_message;
        }

        public Communications()
        {

        }

        public void AddCommunication(int id, int duration, string message)
        {
            DB_Access dB = new DB_Access();
            dB.InsertDecrptMsg(id, duration, message);
        }

        public List<Communications> GetPastComms()  // Using the method for reading all the user data from the DB_Access into a List that we will use for the login details
        {
            List<Communications> returnCommsList = new List<Communications>();
            DataSet RawData = dba.ReadData("Communications");

            foreach (DataRow item in RawData.Tables["Communications"].Rows)
            {
                Communications comms = new Communications();

                comms.idnumber = int.Parse(item["IDNumber"].ToString());
                comms.duration = int.Parse(item["Duration"].ToString());
                comms.message = item["C_Message"].ToString();

                returnCommsList.Add(comms);
            }
            return returnCommsList; 
        }
    }
}
