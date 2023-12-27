using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConversationManager
{
    private DialogueSystem DialogueSystem => DialogueSystem.instance;
    private Coroutine process = null;
    public bool isRunning => process != null;

    private TextArchitect architect = null;

    public ConversationManager(TextArchitect architect)
    {
        this.architect = architect;

    }

    public void StartConversation(List<string> conversation)
    {
        StopConversation();
        process = DialogueSystem.StartCoroutine(RunningConversation(conversation));
    }

    public void StopConversation()
    {
        if (!isRunning)
        {
            return;
        }
        DialogueSystem.StopCoroutine(process);
        process = null;
    }

    IEnumerator RunningConversation(List<string> conversation)
    {
        for (int i = 0; i < conversation.Count; i++)
        {
            if (string.IsNullOrWhiteSpace(conversation[i]))
            {
                Debug.Log("Current Index"+i);
                continue;
            }
                
            Dialogue_Line line = DialogueParser.Parse(conversation[i]);
            Debug.Log("Current Index"+i);

            if (line.hasDialogue)
            {
                Debug.Log("Count of conversation"+conversation.Count);
                yield return Line_RunDialogue(line);
                
            }
               


            if (line.hasCommands)
                yield return Line_RunCommands(line);
            
              
        } 
        yield return new WaitForSeconds(1);

         // Placeholder, replace with your coroutine logic
    }

    IEnumerator Line_RunDialogue(Dialogue_Line line)
    {
        
        architect.Build(line.dialogue);
        while (architect.isBuilding)
            yield return null;

    }

    IEnumerator Line_RunCommands(Dialogue_Line line)
    {
        Debug.Log("here " +line.commands);
        yield return null;

    }
    
}