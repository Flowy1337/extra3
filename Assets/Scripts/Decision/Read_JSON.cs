using System;
using System.Collections.Generic;
using UnityEngine;

public class Read_JSON : MonoBehaviour
{
    //!Start is called before the first frame update,by doing this we ensure that alle Decisions are loaded before the game "starts".
    public TextAsset json;
    reciever Reciever = reciever.Reciever;
    public void Awake()
    {
        List<JSONExample> examples = JSONReader.GetJSON(json);
        
        foreach (var example in examples)
        {
            //!Iterate through each json Objet in examples and create a corresponding Decision Object.
            //!Add Decision to reciever._allDecisions.
            string requirment = example._requirement;
            Debug.Log("Missing part is: " + requirment);
            AllItems _requirment = (AllItems)Enum.Parse(typeof(AllItems),requirment);
            string reward = example._reward;
            AllItems _reward = (AllItems)Enum.Parse(typeof(AllItems), reward);
            Decision d = new Decision(example._decisionID, example._decisionDescription,example._followText,example._timeoutVal,example._triggerOut,example._decisionCall,
                example._decisionFamily,_requirment,_reward);
            Reciever.AddDecision(d);
          
        }
    }

    [System.Serializable]
    public class JSONExample
    {
        //!According member variables of the Decision Class
        public int _decisionID;
        public string _decisionDescription;
        public string _followText;
        public float _timeoutVal;
        public bool _triggerOut;
        public int _decisionCall;
        public int _decisionFamily;
        public string _requirement;
        public string _reward;
        

    }

    public static class JSONReader
    {
        public static List<JSONExample> GetJSON(TextAsset json)
        {
            // !Wrap the JSON array with a root object to make it parseable
            string jsonString = $"{{\"data\":{json.text}}}";
            Debug.Log(jsonString);
            JSONWrapper wrapper = JsonUtility.FromJson<JSONWrapper>(jsonString);

            //! Extract the list of JSONExample objects from the root object
            return wrapper.data;
        }

        [System.Serializable]
        private class JSONWrapper
        {
            
            public List<JSONExample> data;
        }
    }
}