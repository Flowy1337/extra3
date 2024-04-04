using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Decision_Loader : MonoBehaviour
{
    private readonly reciever reciever = reciever.Reciever;
    private readonly TextReciever textReciever = TextReciever.textReciever;
    
    public Click_Decision clickDecision;
    public TextMeshProUGUI ans1;
    public TextMeshProUGUI ans2;
    public TextMeshProUGUI ans3;
    public TextMeshProUGUI ans4;
    public TextMeshProUGUI Text;
    public PictureDisplay pictureDisplay;

    private bool skipTyping = false;
    private float defaultDelay = 0.1f; // Default delay value
    private int parseDecisionID = 0;
    private bool triggerOut = false;
    private int index;
    public float cooldownTime = 2f; // Cooldown time in seconds
    private bool canSkip = true; // Flag to determine if skipping is allowed
    private float cooldownTimer = 0f;
    private bool complete;
    private void Start()    
    {
        LoadTextintoObject(1);
    }
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && canSkip)
        {
            skipTyping = true;
            Debug.Log("SKIPPING");
            StartCooldown();

        }
        if (!canSkip)
        {
            cooldownTimer -= Time.deltaTime;

            // Check if cooldown timer has reached zero
            if (cooldownTimer <= 0)
            {
                // Cooldown finished, allow skipping again
                canSkip = true;
            }
        }
    }




   
    void StartCooldown()
    {
        // Set cooldown timer and disable skipping
        cooldownTimer = cooldownTime;
        canSkip = false;
    }
    private void LoadintoObjects(int start)
    {
        Debug.Log("index is: " + start);
        ans1.text = reciever.GetDecision(start).getdecisionDescription();
        ans2.text = reciever.GetDecision(start + 1).getdecisionDescription();
        ans3.text = reciever.GetDecision(start + 2).getdecisionDescription();
        ans4.text = reciever.GetDecision(start + 3).getdecisionDescription();
        index = start;
    }

    public void LoadTextintoObject(int to_call)
    {
        StartCoroutine(TypeTextAndLoad(to_call));
    }

    public int test = 0;
    IEnumerator TypeTextAndLoad(int to_call)
    {
        // Disable answer objects before typing effect
        ans1.gameObject.SetActive(false);
        ans2.gameObject.SetActive(false);
        ans3.gameObject.SetActive(false);
        ans4.gameObject.SetActive(false);



        
        yield return StartCoroutine(TypeText(textReciever.GetTText(to_call).getdecisionDescription(), 0.03f,to_call));

        // Enable answer objects after typing effect
        ans1.gameObject.SetActive(true);
        ans2.gameObject.SetActive(true);
        ans3.gameObject.SetActive(true);
        ans4.gameObject.SetActive(true);

        int start = to_call * 4 - 3;
        LoadintoObjects(start);

         
    }

    

    public void  getParser(int parseDecisionID)
    {
        this.parseDecisionID = parseDecisionID;
    }

    public void getTriggerOut(bool TriggerOut)
    {
        this.triggerOut = TriggerOut;
        
    }

    IEnumerator TypeText(string text, float delay,int to_call)
    {
        complete = false;

        if (triggerOut )
        {
            pictureDisplay.DisplayPicture(index);
            
        }
        
        
        

        if(parseDecisionID>0)
        {
            Text.text += "<align=right><color=red>";
            Text.text += reciever.GetDecision(parseDecisionID).getdecisionDescription();
            Text.text += "\n";
            Text.text += reciever.GetDecision(parseDecisionID).GetFollowText();
            Text.text += "</color></align>";
        }



        Text.text += "\n";
        Text.text += "\n";



        bool lastCharDisplayed = false; // Flag to check if the last character is displayed

        for (int i = 0; i < text.Length; i++)
        {
            char letter = text[i];
            Text.text += letter;

            // Check if the current character is the last character in the text
            if (i == text.Length - 1)
            {
                lastCharDisplayed = true;

            }

            // Check the variable to skip typing effect
            if (skipTyping)
            {
                Text.text += text;
                lastCharDisplayed = true; // Set the flag to true if skipping typing
                skipTyping = false;
                break;
            }

            yield return new WaitForSeconds(delay);
        }

        Text.text += "\n";
        Text.text += "\n";
     

        Debug.Log( "HEIR ID "+triggerOut ) ;
        



        // Insert dashes after the last character is displayed
        if (lastCharDisplayed)
        {
            complete = true;
        }
    }
    // Method to handle the click event of answer 1
    public void OnAnswer1Clicked()
    {
        // Implement your logic when answer 1 is clicked
    }

    public bool GetComplete()
    {
        return complete;
    }
    
    // Method to handle the click event of answer 2
    public void OnAnswer2Clicked()
    {
        // Implement your logic when answer 2 is clicked
    }

    // Method to handle the click event of answer 3
    public void OnAnswer3Clicked()
    {
        // Implement your logic when answer 3 is clicked
    }

    // Method to handle the click event of answer 4
    public void OnAnswer4Clicked()
    {
        // Implement your logic when answer 4 is clicked
    }

}
