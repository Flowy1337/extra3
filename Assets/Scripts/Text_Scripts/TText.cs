using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TText 
{
    private int _ttextID;
    private string _ttextDescription;
    
    // Public properties for JSON deserialization
    public int DecisionID { get { return _ttextID; } }
    public string DecisionDescription { get { return _ttextDescription; } }
  
    public TText(int ttextID, string ttextDescription)
    {
        //!The Decision object stores all relevant information to identifie a decision
        this._ttextID = ttextID;
        this._ttextDescription = ttextDescription;

    }

    
    public int getDecisionID()
    {
        //! returns the decisionID as a int
        return this._ttextID;
    } 

    public string getdecisionDescription()
    {
        //! returns the decision description as a string
        return this._ttextDescription;
    }

 
}
