using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backbone
{
    public class Role
    {
        public string userID;
        public string role;

        public Role(string userId,string role)
        {
            this.userID = userId;
            this.role = role;
        }
    }
}
