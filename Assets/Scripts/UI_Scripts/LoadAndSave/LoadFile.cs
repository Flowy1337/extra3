using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Plastic.Newtonsoft.Json;
using UnityEngine;
using UnityEngine.Assertions;

public class LoadFile : MonoBehaviour
{
    // Start is called before the first frame update
    private storage storage;
    private Inventory inventory;
    public TextAsset json;
    public Decision_Loader decisionLoader;
    public Click_Decision clickDecision;
 

    // Update is called once per frame
   

    private void OnMouseDown()
    {
        storage = storage.Storage;
        inventory = Inventory.inventory;
        Debug.Log("Called");
        RootObject data = JsonConvert.DeserializeObject<RootObject>(json.text);
        LoadInventory(data);
        LoadGameState(data);
        Debug.Log(storage.returnLast().getdecisionDescription());
    }

    private void LoadInventory(RootObject data)
    {
        inventory.DropInventory();
        foreach (var VARIABLE in data.GetCurrentInventory)
        {
            
            inventory.AddtoInventory((AllItems)Enum.Parse(typeof(AllItems), VARIABLE));
        }    
    }

    private void LoadGameState(RootObject data)
    {
        storage.DropStorage(); //!We ensure that the storage is empty before calling file
        Decision d = new Decision(data.GetLastDecision.getDecisionID(),data.GetLastDecision.getdecisionDescription(), data.GetLastDecision.GetFollowText(),
            data.GetLastDecision.GetTimeOutVal(), data.GetLastDecision.getTriggerOut(),data.GetLastDecision.getdecisionCall(),data.GetLastDecision.GetDecisionFamily(),
            data.GetLastDecision.GetRequirment(), data.GetLastDecision.getReward());
            storage.AddDecision(d);
            decisionLoader.LoadTextintoObject(d.getdecisionCall());
            clickDecision.SetRoundExtern((d.getdecisionCall()*4)-3);
    }
    [System.Serializable]

    public class DecisionJSON
    {
        public int DecisionID { get; set; }
        public string DecisionDescription { get; set; }
        public string DecisionFollowtext { get; set; }
        public double DecisiontimeoutVal { get; set; }
        public bool DecisiontriggerOut { get; set; }
        public int Decisionrequirment { get; set; }
        public int Decisionreward { get; set; }
        public int DecisionCall { get; set; }
        public int DecisionFamily { get; set; }
    }

    public class InventoryJSON
    {
        public List<string> GetCurrentInventory { get; set; }
    }

    public class RootObject
    {
        public Decision GetLastDecision { get; set; }
        public List<string> GetCurrentInventory { get; set; }
    }
    
}
