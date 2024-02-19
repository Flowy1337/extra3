using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Inventory_test
{
    Inventory Inventory = Inventory.inventory;
    
    [Test]
    public void AddtoInventory_test()
    {
        
        Inventory.AddtoInventory(AllItems.Knife);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
  
}
