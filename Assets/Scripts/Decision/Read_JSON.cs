using System.Collections.Generic;
using UnityEngine;

public class Read_JSON : MonoBehaviour
{
    //!Start is called before the first frame update,by doing this we ensure that alle Decisions are loaded before the game "starts".
    public TextAsset json;
    reciever Reciever = reciever.Reciever;
    void Start()
    {
        List<JSONExample> examples = JSONReader.GetJSON(json);
        
        foreach (var example in examples)
        {
            //!Iterate through each json Objet in examples and create a corresponding Decision Object.
            //!Add Decision to reciever._allDecisions.
            Decision d = new Decision(example._decisionID, example._decisionDescription, example._decisionCall,example._decisionFamily);
            Reciever.AddtoContainer(d);
        }
    }

    [System.Serializable]
    public class JSONExample
    {
        public int _decisionID;
        public string _decisionDescription;
        public int _decisionCall;
        public int _decisionFamily;
    }

    public static class JSONReader
    {
        public static List<JSONExample> GetJSON(TextAsset json)
        {
            // !Wrap the JSON array with a root object to make it parseable
            string jsonString = $"{{\"data\":{json.text}}}";
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