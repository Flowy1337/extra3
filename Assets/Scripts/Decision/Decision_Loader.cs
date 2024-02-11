using System.Collections;
using UnityEngine;
using TMPro;

public class Decision_Loader : MonoBehaviour
{
    private readonly reciever reciever = reciever.Reciever;
    private readonly TextReciever textReciever = TextReciever.textReciever;
    public TextMeshProUGUI ans1;
    public TextMeshProUGUI ans2;
    public TextMeshProUGUI ans3;
    public TextMeshProUGUI ans4;
    public TextMeshProUGUI Text;

    private float defaultDelay = 0.1f; // Default delay value

    private void Start()
    {
        LoadTextintoObject(1);
    }

    private void LoadintoObjects(int start)
    {
        ans1.text = reciever.GetDecision(start).getdecisionDescription();
        ans2.text = reciever.GetDecision(start + 1).getdecisionDescription();
        ans3.text = reciever.GetDecision(start + 2).getdecisionDescription();
        ans4.text = reciever.GetDecision(start + 3).getdecisionDescription();
    }

    public void LoadTextintoObject(int to_call)
    {
        StartCoroutine(TypeTextAndLoad(to_call));
    }

    IEnumerator TypeTextAndLoad(int to_call)
    {
        // Disable answer objects before typing effect
        ans1.gameObject.SetActive(false);
        ans2.gameObject.SetActive(false);
        ans3.gameObject.SetActive(false);
        ans4.gameObject.SetActive(false);

       

        
        yield return StartCoroutine(TypeText(textReciever.GetTText(to_call).getdecisionDescription(), 0.03f));

        // Enable answer objects after typing effect
        ans1.gameObject.SetActive(true);
        ans2.gameObject.SetActive(true);
        ans3.gameObject.SetActive(true);
        ans4.gameObject.SetActive(true);

        int start = to_call * 4 - 3;
        LoadintoObjects(start);

         
    }

    IEnumerator TypeText(string text, float delay)
    {
        Text.text = ""; // Clear existing text
        foreach (char letter in text)
        {
            Text.text += letter;

            // Check for left mouse button click to skip typing effect
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Text.text = text;
                break;
            }

            yield return new WaitForSeconds(delay);
        }
    }
}
