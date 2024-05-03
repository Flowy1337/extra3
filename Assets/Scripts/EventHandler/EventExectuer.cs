using System.Collections;
using TMPro;
using UnityEngine;

using UnityEngine.UI;

public class EventExectuer : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI notificationObject;
    public GameObject leftpicture;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator ShowNotification(string notificationText)
    {
        // Deaktiviere das linke Bild
        //leftpicture.SetActive(false);
        Debug.Log("Starting notifciaton");
        leftpicture.GetComponent<Image>().enabled = false;
        
        // Aktiviere das Benachrichtigungsobjekt und setze den Text
        notificationObject.enabled = true;
        notificationObject.text = notificationText;
        Debug.Log("Starting waiting timer");

        // Warte für die angegebene Zeit
        yield return new WaitForSecondsRealtime(5);
        Debug.Log("Finished");
        leftpicture.GetComponent<Image>().enabled = true;

        // Deaktiviere das Benachrichtigungsobjekt
        notificationObject.enabled = false;
    }

   
    public void triggerEvent(EventHandler eventHandler)
    {
        
        switch (eventHandler.GetType)
        {
            case EventEnum.backgroundpicture:
                Debug.Log("Chanigng background now");
                leftpicture.GetComponent<Image>().sprite =
                    Resources.Load<Sprite>("Pictures/Backgroundpictures/" + eventHandler.GetId);
                break;
            case EventEnum.notification:
                StartCoroutine(ShowNotification(eventHandler.GetString));  

                    break;
            case EventEnum.inventory:
                Debug.Log("inventory");
                break;

        }
        //imageHolder.GetComponent<Image>().enabled = false;
    }
}
