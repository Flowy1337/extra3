using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.Plastic.Newtonsoft.Json;
using UnityEngine;

public class reciever
{
    private static reciever _reciever;
    Dictionary<int, Decision> _allDecisions = new Dictionary<int, Decision>();


    private reciever()
    {


    }

    //!Reciever is build by the singleton design pattern
    public static reciever Reciever
    {
        get
        {
            if (_reciever == null)
            {
                _reciever = new reciever();
            }

            return _reciever;
        }
    }

    public void show()
    {
        //!Show logs all possible decisions which are avaliable in the game line by line to the console
        //! This is mainly for debugging purposes
      Debug.Log("Hello Recievi");
    
      
    }

    public void AddtoContainer(Decision d)
    {
        if (!_allDecisions.ContainsKey(d.getDecisionID()))
        {
            _allDecisions.Add(d.getDecisionID(),d);
        }
    }
    
    public Decision getDecision(int decisionID)
    {
        //!Retrieves a specific Decision which is identified by the unique decisionID
        
        return _allDecisions[decisionID];
                
    }

    public int size()
    {
        return _allDecisions.Count;
    }

  
  


 

   
}
