
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueSystem  : MonoBehaviour
{
    public DialogueContainer dialogueContainer = new DialogueContainer();

    public static DialogueSystem instance;

    private void Awake(){
        if(instance==null){
            instance=this;

        }
        else{
            DestroyImmediate(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // Your start logic here
    }

    // Update is called once per frame
    void Update()
    {
        // Your update logic here
    }
}
