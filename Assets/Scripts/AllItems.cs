using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Flags]
public enum AllItems
{
    Bag    = 0b_0000_000000,  // 0
    Feuerzeug = 0b_0000_0000001,
    Taschenlampe = 0b_0000_000010,
    flag_askedworktime = 0b_0000_000100,
    flag_askedtestalarm = 0b_0000_001000,
    flag_Cut = 0b_000001_0000,
    flag_Sarahdesk = 0b_000010_0000,
    flag_Jamesdesk = 0b_000100_0000,
    flag_Danieldesk = 0b_0100_000000,
    flag_Oliviadesk = 0b_1000_000000,
    Flag_asked_for_worktime = 0b_00000_000001,
    Block = 0b_0000_00000010,
    flag_testalarm = 0b_00000_000011,
    flag_Emilydesk = 0b_0000_0000100,
    Knife = 0b_0000_0000101,
    Keys = 0b_0000_0000110,
    emergency_plan = 0b_0000_0000111,
    flag_portier = 0b_0000_0001000

}