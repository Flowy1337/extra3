using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextReciever {
    
    private static TextReciever _textreciever;
    Dictionary<int, TText> allDecisions = new Dictionary<int,TText>();


    private TextReciever()
    {


    }

    //!Reciever is build by the singleton design pattern
    public static TextReciever textReciever
    {
        get
        {
            if (_textreciever == null)
            {
                _textreciever = new TextReciever();
            }

            return _textreciever;
        }
    }
    
    public void AddTText(TText d)
    {
        if (!allDecisions.ContainsKey(d.getDecisionID()))
        {
            //! Add a decision to _allDecisions.
            allDecisions.Add(d.getDecisionID(),d);
            return;
        }
        Debug.Log("Already here");
    }
    
    public  TText GetTText(int textID)
    {
        //!Retrieves a specific Decision which is identified by the unique decisionID
        return allDecisions[textID];
    }

    public  int Size()
    {
        return allDecisions.Count;
    }

  
    public void Droptable()
    {
        allDecisions.Clear();
    }

    
}
