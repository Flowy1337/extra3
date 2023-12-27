using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue_Line
{
    public string dialogue;
    public string commands;

   public bool hasDialogue => dialogue != string.Empty;
   
    public bool hasCommands => commands != string.Empty;
    public Dialogue_Line(string dialogue, string commands)
    {
        this.dialogue = dialogue;
        this.commands = commands;
    }

}
