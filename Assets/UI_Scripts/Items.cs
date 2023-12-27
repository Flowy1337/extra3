using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class Items : MonoBehaviour
{
    public abstract bool Active(); //Every Item can be active/not-active, there fore included in the class
    public abstract void open_item(); 
    public abstract void close_item();


}
