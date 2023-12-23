using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue_Line
{
    public string Dialogue;
    public string commands;

    public Dialogue_Line(string dialogue, string commands)
    {
        this.Dialogue = dialogue;
        this.commands = commands;
    }

}
