using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//! The Decision class stores a unique ID,description,decisionCall,decisionFamily \n
//!All values are stored as an int,since we wont't handle huge numbers. Furthermore, we don't provide any setters, since we're not interested in manipulate choices made
public class Decision
{
    private int _decisionID; 
    private string _decisionDescription;
    private int _decisionCall; 
    private int _decisionFamily;

    private AllItems _requirment;

    private AllItems _reward;
    // Public properties for JSON deserialization
    public int DecisionID { get { return _decisionID; } }
    public string DecisionDescription { get { return _decisionDescription; } }
    public int DecisionCall { get { return _decisionCall; } }
    public int DecisionFamily { get { return _decisionFamily; } }
    public Decision(int decisionID, string decisionDescription,int decisionCall,int decisionFamily,AllItems requirment,AllItems reward)
    {
        //!The Decision object stores all relevant information to identifie a decision
        this._decisionID = decisionID;
        this._decisionDescription = decisionDescription;
        this._decisionCall = decisionCall;
        this._decisionFamily = decisionFamily;
        this._requirment = requirment;
        this._reward = reward;
    }

    
    public int getDecisionID()
    {
        //! returns the decisionID as a int
        return this._decisionID;
    } 

    public string getdecisionDescription()
    {
        //! returns the decision description as a string
        return this._decisionDescription;
    }

    public int getdecisionCall()
    {
        //! returns the decisionCall as an int, the value represents the order in which this decision was made

        return this._decisionCall;
    }

    public AllItems getReward()
    {
        return this._reward;
    }
   
}
