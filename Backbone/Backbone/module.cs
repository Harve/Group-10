using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Module
{
    public string moduleID;
    public string moduleLeaderID;
    public List<string> moduleTeamID;
    public string programmeID;
    public string title;

	public Module(string moduleid,string Title, string programme)
	{
        moduleID = moduleid;
        title = Title;
        programmeID = programme;
        moduleTeamID = new List<string>();
	}

    
}
