using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Map_test
{
    Handy h1 = Handy.Instanz;

    // A Test behaves as an ordinary method
    [Test]
    public void Handy_singleton()
    {
        Handy h2 = Handy.Instanz;
        Assert.AreEqual(h1, h2);
    }
    [Test]
    public void Handy_openitem()
    {
        int current = h1.get_count()+1;
        h1.open_item();
        Assert.AreEqual(current, h1.get_count());
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator Map_testWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }

    [Test]
    public void decisiontest()
    {
        storage storage = storage.Storage;
        Decision decision = new Decision(1, "Cave or forrest?", 0,0);
        storage.AddDecision(decision);
        Assert.IsTrue(storage.getDecision(decision.getDecisionID())!=null);
        reciever reciever = reciever.Reciever;
       

    }
}
