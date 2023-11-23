using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingArch : MonoBehaviour
{

    DialogueSystem ds;
    TextArchitect architect;

    string[] lines = new string[5]{
        "This is my first textSDASDADDADADADADADADADADADADADADADASDASDASDASDASDASDASDASDASDASDASDASDASsssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssD",
        " and will be also my last text ",
        "TEst",
        "TOST",
        "LÜGE"
    };

    // Start is called before the first frame update
 // Start is called before the first frame update
void Start()
{
    ds = DialogueSystem.instance;

    // Check if DialogueSystem and its properties are accessible
    if (ds != null && ds.dialogueContainer != null && ds.dialogueContainer.dialogueText != null)
    {
        architect = new TextArchitect(ds.dialogueContainer.dialogueText);
        architect.buildMethod = TextArchitect.BuildMethod.typewriter;
    }
    else
    {
        Debug.LogError("DialogueSystem or its properties are not accessible.");
    }
}   


    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown("space"))
        {
            Debug.Log("Testing!!!!!");
            if(architect.isBuilding){

                if(!architect.hurryUp){
                    architect.hurryUp=true;
                }
                
                else{
                    architect.forceComplete();

                }
                
                
            }
            else{
                    architect.Build(lines[0]);

                }
         
            
        }
        else if (Input.GetKeyDown(KeyCode.A)){
            architect.Append(lines[Random.Range(0,5)]);
        }
        
    }
}
