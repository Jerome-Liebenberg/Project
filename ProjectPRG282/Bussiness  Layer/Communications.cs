using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bussiness__Layer
{
    class Communications
    {
        private int idnumber;
        private int messageid;
        private DateTime duration;
        private string message;

        public int Idnumber { get => idnumber; set => idnumber = value; }
        public int Messageid { get => messageid; set => messageid = value; }
        public DateTime Duration { get => duration; set => duration = value; }
        public string Message { get => message; set => message = value; }

        public Communications(int c_idnumber,int c_messageid,DateTime c_duration,string c_message)
        {
            this.idnumber = c_idnumber;
            this.messageid = c_messageid;
            this.duration = c_duration;
            this.message = c_message;
        }
    }
}
