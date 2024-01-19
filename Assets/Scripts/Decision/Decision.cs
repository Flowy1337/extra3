using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decision
{
    private int _decisionID;
    private string _decisionDescription;
    private int _decisionCall; //When the decision was made e.g, how many decision were made prior to this
    public Decision(int decisionID, string decisionDescription,int decisionCall)
    {
        this._decisionID = decisionID;
        this._decisionDescription = decisionDescription;
        this._decisionCall = decisionCall;
    }

    
    public int getDecisionID()
    {
        return this._decisionID;
    }

    public string getdecisionDescription()
    {
        return this._decisionDescription;
    }

    public int getdecisionCall()
    {
        return this._decisionCall;
    }
    
}
