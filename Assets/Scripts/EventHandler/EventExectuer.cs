using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventExectuer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject imageHolder;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangePicture(EventHandler eventHandler)
    {
        switch (eventHandler.GetType)
        {
            case EventEnum.inventory:
                imageHolder.GetComponent<Image>().sprite =
                    Resources.Load<Sprite>("Pictures/Backgroundpictures/" + eventHandler.GetId);
                break;
            case EventEnum.notification:
                Debug.Log("not coverd");
                break;

        }
        //imageHolder.GetComponent<Image>().enabled = false;
    }
}
