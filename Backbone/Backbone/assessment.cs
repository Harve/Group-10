using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Assessment
{
    public string assessmentID;
    public string moduleTeamMemberID;
    public string moduleID;
    public string title;

    public List<string> progressSteps = new List<string>();
    public int lastStep;
    public int nextStep;

	public Assessment(string assessmentid, string ModID, string userID,string lastStep,string nextStep)
	{
        assessmentID = assessmentid;
        moduleID = ModID;
        moduleTeamMemberID = userID;

        this.lastStep = int.Parse(lastStep);
        this.nextStep = int.Parse(nextStep);

        progressSteps.Add("Create Assesment");//0
        progressSteps.Add("First Moderation");//1
        progressSteps.Add("Moderation Feedback Implementation");//2
        progressSteps.Add("Send to Program Director");//3
        progressSteps.Add("Panel Review");//4
        progressSteps.Add("Panel Aproval");//5
        progressSteps.Add("Minor Modifications");//6
        progressSteps.Add("Major Modifications");//7
        progressSteps.Add("Moderation");//8
        progressSteps.Add("Panel Chair Aproval");//9
        progressSteps.Add("Sent To External Examiner");//10
        progressSteps.Add("Modify Based on External Scrutiny");//11
        progressSteps.Add("Sign off by Module Leader");//12
        progressSteps.Add("Finished");//13
        progressSteps.Add("Finished");//14
    }

    public string getLastStep()
    {
        return progressSteps[lastStep];
    }
    public string getNextStep()
    {
        return progressSteps[nextStep];
    }


}
