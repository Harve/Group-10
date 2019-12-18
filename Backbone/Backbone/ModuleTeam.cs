using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backbone
{
    public class ModuleTeam
    {
        public string moduleID;
        public string userID;

        public ModuleTeam(string moduleID,string userID)
        {
            this.moduleID = moduleID;
            this.userID = userID;
        }
    }
}
