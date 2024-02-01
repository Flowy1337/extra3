using System.Collections.Generic;
using System.IO;
using UnityEngine;
//Reciever is a singleton, by using load_decision we can load all the decision of a given typ
//Since our gameobjects all have a unique name wen can use this script for the action handling

//By clicking on the Object we will store the decision in the storage and pop one value out of the Decision list, the Decision List next stores all Decision which can be applied next
public class Click_Decision : MonoBehaviour
{
    storage storage = storage.Storage;
    private reciever reciever;
    private List<Decision> next;
    [Range(1,40)]
    private static int round = 1;
    void Start()
    {
        reciever = reciever.Reciever;
        
    }

    // Update is called once per frame
    void Update()
    {
    }

   
    private void OnMouseDown()
    {
        if (round >= 40)
        {
            storage.AddDecision(new Decision(41,"You've finished the game :)",1,11));
            Debug.Log(storage.getDecision(41).getdecisionDescription());
            return;
        }
        switch (gameObject.name)
        {
            case "A1":
                storage.AddDecision(reciever.getDecision(round));
                Debug.Log(storage.getDecision(round).getdecisionDescription());
                round += 4;
                break;
            case "A2":
                storage.AddDecision(reciever.getDecision(round+1));
                Debug.Log(storage.getDecision(round+1).getdecisionDescription());

                round += 4;
                break;
            case "A3":
                storage.AddDecision(reciever.getDecision(round+2));
                Debug.Log(storage.getDecision(round+2).getdecisionDescription());

                round += 4;
                break;
            case "A4":
                storage.AddDecision(reciever.getDecision(round+3));
                Debug.Log(storage.getDecision(round+3).getdecisionDescription());
                Debug.Log(reciever.size());
                Debug.Log(storage.size());
                round += 4;
                break;
                
            
                
        }
        
    }
}
