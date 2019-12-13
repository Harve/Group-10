using System;

public class Assessment
{
    public string assessmentID;
    public string moduleTeamMemberID;
    public string moduleID;
    public string progressTracker;
    public string title;

	public Assessment(string assessmentid, string title, string ModID)
	{
        assessmentID = assessmentid;
        this.title = title;
        moduleID = ModID;
        
	}
}
