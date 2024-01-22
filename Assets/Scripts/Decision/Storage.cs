using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class storage 
    {
        private static storage _storage;
        Dictionary<int, Decision> myMap = new Dictionary<int, Decision>(); //!Dictionary since we wan't fast acess to made decisions
        

        private storage(){         


            
        }
        //!Generate a storage instanz via a singleton pattern,we use a singleton pattern since we only allow one object of the class storage to exist at a time
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
                //!Adds a decision object to the Dictionary

        }
        //!Returns the Decision made by the player, the decisionID is a unique value for a given Decision
        public Decision getDecision(int decisionID)
        {
            //!Retrieves a specific Decision which is identified by the unique decisionID
            
            
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
                //!Prints all Decisions which are currently stored to the Console, this is mainly for debugging purposes
            }
        }

     

    
}


