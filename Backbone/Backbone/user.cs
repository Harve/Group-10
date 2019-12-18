using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backbone
{
    
    public class User
    {
        public string id;
        public string firstname;
        public string surname;
        public User(string userid, string fname, string sname)
        {
            id = userid;
            firstname = fname;
            surname = sname;
        }
    }
}
