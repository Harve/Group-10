using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Programme
{


    public string programmeID;
    public string programmeDirectorID;
    public string title;
  


	public Programme(string programmeid, string directorid, string ttle)
	{
        programmeID = programmeid;
        programmeDirectorID = directorid;
        title = ttle;

        
	}

    public string getModules()
    {
        return "a";
    }
}
