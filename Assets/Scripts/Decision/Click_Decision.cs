
using Codice.Client.BaseCommands;
using UnityEngine;
using UnityEngine.Serialization;

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
    [FormerlySerializedAs("eventTrigger")] public EventExectuer eventExectuer;
    void Start()
    {
        reciever = reciever.Reciever;
    }

    public int GetParseDecisionID()
    {
        return parseDescionID;
    }

    private void SetNextRound(int round)
    {
        storage.AddDecision(reciever.GetDecision(round)); //Round has to be the first decision of the current family
        jumpto = reciever.GetDecision(round).getdecisionCall();
        inventory.AddtoInventory(reciever.GetDecision(round).getReward());
        parseDescionID = reciever.GetDecision(round).getDecisionID();
        Trigger = reciever.GetDecision(round).getTriggerOut();
        if (reciever.GetDecision(round).getTriggerOut())
        {
            Debug.Log("Decision fires event...");
            eventExectuer.ChangePicture(reciever.GetEvent(reciever.GetDecision(round).getDecisionID()));

        }
        
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
                SetNextRound(_round);
                break;
            case "A2":
                SetNextRound(_round+1);
                break;
            case "A3":  
                SetNextRound(_round+2);
                break;
            case "A4":
                SetNextRound(_round+3);
                break;
        }
        _round = jumpto * 4 - 3; //! _round is set to jumpto, hence we're currently in the same family
        decisionLoader.setParser(parseDescionID);
        decisionLoader.setTriggerOut(Trigger);
        decisionLoader.LoadTextintoObject(jumpto);
        inventory.Show();
    
    }

    public void SetRoundExtern(int newRound)
    {
        _round = newRound;
    }
}
