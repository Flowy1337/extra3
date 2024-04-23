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
    
    public AllItems InventoryItem
    {
        get { return current_items; }
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
        //!Check through set operation if item is contained
        if((current_items & item) == item)
        {
            return true;
        }

        return false;
    }

    public AllItems GetCurrentItems()
    {
        return this.current_items;
    }

    public void DropInventory()
    {
        //!Since Annie will always have a Bag on here, this is the same as deleting all Items
        this.current_items = AllItems.Bag;
    }
    
}
