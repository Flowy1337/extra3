using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class storage 
    {
        private static storage _storage;
        Dictionary<int, Decision> myMap = new Dictionary<int, Decision>();
        

        private storage(){

            
        }
        public static storage Storage
        {
            get
            {
                if (_storage == null)
                {
                    _storage = new storage();
                }

                return _storage;
            }
        }

        public void AddDecision(Decision d)
        {
            
                myMap.Add(d.getDecisionID(),d);
        }

        public Decision getDecision(int decisionID)
        {
            return myMap[decisionID];
        }

        public void logging()
        {
            Debug.Log(myMap.Count + " is in store");
        }

        public void getAllDecision()
        {
            foreach (KeyValuePair<int, Decision> kvp in myMap)
            {
                int key = kvp.Key;
                Decision decision = kvp.Value;

                Debug.Log($"Key: {key}, Description: {decision.getdecisionDescription()}");
                // Access other properties of the Decision class if needed
            }
        }

     

    
}


