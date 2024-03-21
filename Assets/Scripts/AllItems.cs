using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Flags]
public enum AllItems
{
    Bag    = 0b_0000_0000,  // 0
    Flag_asked_for_worktime    = 0b_0000_0001,  // 1
    flag_testalarm   = 0b_0000_0010,  // 2
    Feuerzeug = 0b_0000_0100,  // 4
    Taschenlampe  = 0b_0000_1000,  // 8
    Block = 0b_0001_0000, //16
}
