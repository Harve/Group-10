using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backbone
{
    public class Deadline
    {
        public string assessmentid;
        public string title;
        public DateTime deadlineDate;
        public Deadline(string moduleID, string Title, DateTime date)
        {
            assessmentid = moduleID;
            title = Title;
            deadlineDate = date;
        }
    }
}
