using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backbone
{
    
    public class notification
    {
        public string id;
        public string message;
        public string sender;
        public string reciever;
        public DateTime sentDate;

        public notification(string notifid,string message,string sender,string reciever, DateTime dateTime)
        {
            id = notifid;
            this.message = message;
            this.sender = sender;
            this.reciever = reciever;
            sentDate = dateTime;
        }

    }
}
