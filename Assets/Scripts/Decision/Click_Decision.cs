
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
    void Start()
    {
        reciever = reciever.Reciever;
    }
   
 
   
    private void OnMouseDown()
    {
        //! By clicking on of the 4 Gameobjects we set our Decision, afterwards, the new Decision Family is loaded.\n
        if (_round >= 40)
        {
            //! We ensure that we won't run out of bound by checking before we call AddDecision\n
            storage.AddDecision(new Decision(41,"You've finished the game :)",1,11));
            //Debug.Log(storage.getDecision(41).getdecisionDescription());
            return;
        }
        
        switch (gameObject.name)
        {
            //!If a Object is clicked we add the Decision to storage._myMap, then increment round+=4 to recieve the next block of decisions
            case "A1":
                storage.AddDecision(reciever.GetDecision(_round));
                //Debug.Log(storage.getDecision(round).getdecisionDescription());
                _round += 4;
                break;
            case "A2":
                storage.AddDecision(reciever.GetDecision(_round+1));
                //Debug.Log(storage.getDecision(round+1).getdecisionDescription());
                _round += 4;
                break;
            case "A3":
                storage.AddDecision(reciever.GetDecision(_round+2));
                //Debug.Log(storage.getDecision(round+2).getdecisionDescription());
                _round += 4;
                break;
            case "A4":
                storage.AddDecision(reciever.GetDecision(_round+3));
                //Debug.Log(storage.getDecision(round+3).getdecisionDescription());
                _round += 4;
                break;
        }
        decisionLoader.LoadintoObjects(_round); //!Call LoadintoObjects from decisionLoader with incremented Value of round.
    }
    
}
