using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Flags]
public enum AllItems
{
    Bag    = 0b_0000_0000,  // 0
    Lab_Key    = 0b_0000_0001,  // 1
    Knife   = 0b_0000_0010,  // 2
    Night_glasses = 0b_0000_0100,  // 4
    Password  = 0b_0000_1000,  // 8
}
