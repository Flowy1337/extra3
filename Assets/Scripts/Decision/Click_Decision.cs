using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_Decision : MonoBehaviour
{
    storage storage = storage.Storage;
    private Decision d = new Decision(0, "Koray has been slayn?", 0, 0);
    private Decision d2 = new Decision(1, "Koray can't aim that good", 0, 0);

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseOver()
    {
        //storage.logging();
    }

    private void OnMouseDown()
    {

        if (storage.getDecision(d.getDecisionID()) != null) //Otherwise, decision is already written...
        {
            storage.AddDecision(d);

        }
        storage.getAllDecision();

    }
}
