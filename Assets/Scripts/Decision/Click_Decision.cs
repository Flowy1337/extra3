
using Codice.Client.BaseCommands;
using UnityEngine;
//Reciever is a singleton, by using load_decision we can load all the decision of a given typ
//Since our gameobjects all have a unique name wen can use this script for the action handling

//!By clicking on the Object we will store the decision in the storage and pop one value out of the Decision list, the Decision List next stores all Decision which can be applied next
public class Click_Decision : MonoBehaviour
{
    storage storage = storage.Storage;
    private reciever reciever;
    private static int _round = 1;
    public Decision_Loader decisionLoader;
    private static int jumpto = 1;
    Inventory inventory = Inventory.inventory;
    public int parseDescionID=0;
    public bool Trigger = false;
    void Start()
    {
        reciever = reciever.Reciever;
    }

    public int GetParseDecisionID()
    {
        return parseDescionID;
    }
   
    private void OnMouseDown()
    {
        
        //! By clicking on of the 4 Gameobjects we set our Decision, afterwards, the new Decision Family is loaded.\n
        if (_round >= 40)
        {
            //! We ensure that we won't run out of bound by checking before we call AddDecision\n
            //storage.AddDecision(new Decision(41,"You've finished the game :)",1,11));
            //Debug.Log(storage.getDecision(41).getdecisionDescription());
            return;
        }
        
        switch (gameObject.name)
        {
            //!If a Object is clicked we add the Decision to storage._myMap, then increment round+=4 to recieve the next block of decisions
            case "A1":
                Debug.Log("1 Antwort" + parseDescionID);
                storage.AddDecision(reciever.GetDecision(_round)); //Round has to be the first decision of the current family
                jumpto = reciever.GetDecision(_round).getdecisionCall();
                inventory.AddtoInventory(reciever.GetDecision(_round).getReward());
                parseDescionID = reciever.GetDecision(_round).getDecisionID();
                Trigger = reciever.GetDecision(_round).getTriggerOut();

                break;
            case "A2":
              
                storage.AddDecision(reciever.GetDecision(_round+1));
                jumpto = reciever.GetDecision(_round+1).getdecisionCall();
                inventory.AddtoInventory(reciever.GetDecision(_round+1).getReward());
                parseDescionID = reciever.GetDecision(_round).getDecisionID()+1;
                Debug.Log("2 Antwort" + parseDescionID);
                Trigger = reciever.GetDecision(_round).getTriggerOut();

                break;
            case "A3":
                storage.AddDecision(reciever.GetDecision(_round+2));
                jumpto = reciever.GetDecision(_round+2).getdecisionCall();
                inventory.AddtoInventory(reciever.GetDecision(_round+2).getReward());
                parseDescionID = reciever.GetDecision(_round).getDecisionID()+2;
                Trigger = reciever.GetDecision(_round).getTriggerOut();
                break;
            case "A4":
                storage.AddDecision(reciever.GetDecision(_round+3));
                jumpto = reciever.GetDecision(_round+3).getdecisionCall();
                inventory.AddtoInventory(reciever.GetDecision(_round+3).getReward());
                parseDescionID = reciever.GetDecision(_round).getDecisionID()+3;
                Trigger = reciever.GetDecision(_round).getTriggerOut();
                break;
        }
        _round = jumpto * 4 - 3; //! _round is set to jumpto, hence we're currently in the same family
        Debug.Log(_round);
        decisionLoader.getParser(parseDescionID);
        decisionLoader.getTriggerOut(Trigger);
        decisionLoader.LoadTextintoObject(jumpto);
        inventory.Show();
    
    }
      
    
}
