using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backbone
{
    public class Deadline
    {
        public string moduleid;
        public string title;
        public DateTime deadlineDate;
        public Deadline(string moduleID, string Title, DateTime date)
        {
            moduleid = moduleID;
            title = Title;
            deadlineDate = date;
        }
    }
}
