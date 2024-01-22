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
    public Decision(int decisionID, string decisionDescription,int decisionCall,int decisionFamily)
    {
        //!The Decision object stores all relevant information to identifie a decision
        this._decisionID = decisionID;
        this._decisionDescription = decisionDescription;
        this._decisionCall = decisionCall;
        this._decisionFamily = decisionFamily;
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
   
}
