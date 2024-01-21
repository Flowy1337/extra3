using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reciever
{
    // Start is called before the first frame update
    private static reciever _reciever;
    private static List<string> decision_container = FileManager.ReadTextAsset("testFile");



    private reciever()
    {


    }

    public static reciever Reciever
    {
        get
        {
            if (_reciever == null)
            {
                _reciever = new reciever();
            }

            return _reciever;
        }
    }

    public void show()
    {
        Debug.Log(decision_container.Count);
        foreach (var VARIABLE in decision_container)
        {
            Debug.Log( VARIABLE);
        }
    }


    public void getDecisions_from_txt()
    {
        decision_container.Clear();
        List<string> lines = FileManager.ReadTextAsset("testFile");

        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
                return;
            Debug.Log($"Segmenting line '{line}'");
            Dialogue_Line dline = DialogueParser.Parse(line);
            decision_container.Add(line);

        }
    }
}
