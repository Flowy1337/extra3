using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reciever
{
    private static reciever _reciever;
    private static List<string> decision_container = FileManager.ReadTextAsset("testFile");



    private reciever()
    {


    }

    //!Reciever is build by the singleton design pattern
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
        //!Show logs all possible decisions which are avaliable in the game line by line to the console
        //! This is mainly for debugging purposes
        Debug.Log(decision_container.Count);
        foreach (var VARIABLE in decision_container)
        {
            Debug.Log( VARIABLE);
        }
    }


    public void getDecisions_from_txt()
    {
        //!Retrieves plaine text from a txt file, then converts each line to a decision object and stores it in the List
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
