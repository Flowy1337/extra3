using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{

    private static Inventory _inventory;
    private AllItems current_items = AllItems.Bag;

    private Inventory()
    {
        
    }

    public static Inventory inventory
    {
        get
        {
            if (_inventory == null)
            {
                _inventory = new Inventory();
            }

            return _inventory;
        }
    }

    public void Show()
    {
       
        Debug.Log(current_items);
    }

    public void AddtoInventory(AllItems x)
    {
        this.current_items = current_items | x;
    }

    public bool contains(AllItems item)
    {
        if((current_items & item) == item)
        {
            return true;
        }

        return false;
    }

}
