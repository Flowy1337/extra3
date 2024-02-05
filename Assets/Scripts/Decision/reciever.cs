using System.Collections.Generic;


public class reciever : text_holder
{
    //!The reciever class holds a Dictionary _allDecisions, as the name implies, all possible Decisions are stored here.
    
    private static reciever _reciever;
    Dictionary<int, Decision> allDecisions = new Dictionary<int, Decision>();


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
    
    public override void AddDecision(Decision d)
    {
        if (!allDecisions.ContainsKey(d.getDecisionID()))
        {
            //! Add a decision to _allDecisions.
            allDecisions.Add(d.getDecisionID(),d);
        }
    }
    
    public override Decision GetDecision(int decisionID)
    {
        //!Retrieves a specific Decision which is identified by the unique decisionID
        return allDecisions[decisionID];
    }

    public override int Size()
    {
        return allDecisions.Count;
    }

  
    public void Droptable()
    {
        allDecisions.Clear();
    }


 
  
}
