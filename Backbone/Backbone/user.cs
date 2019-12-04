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
        public string role;
        public User(string userid, string fname, string sname, string Role)
        {
            id = userid;
            firstname = fname;
            surname = sname;
            role = Role;
        }
    }
}
