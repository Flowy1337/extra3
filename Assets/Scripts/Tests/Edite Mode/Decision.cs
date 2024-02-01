using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Decision_Test
{
    Decision d1 = new Decision(1, "Go to the cave", 1, 1);
    Decision d2 = new Decision(2, "Drink from the river", 1, 1);
    Decision d3 = new Decision(3, "Jump over the hill", 1, 1);
    Decision d4 = new Decision(4, "Hide", 1, 1);
    Decision d5 = new Decision(5, "Explore the forest", 1, 2);
    Decision d6 = new Decision(6, "Climb a tree", 1, 2);
    Decision d7 = new Decision(7, "Follow the path", 1, 2); 
    Decision d8= new Decision(8, "Go home", 1, 2); 
    reciever reciever = reciever.Reciever;
    storage storage = storage.Storage;
    
    [Test]
    public void Read_JSONTest()
    {
        prepareData();
        Assert.AreEqual(reciever.size(),8); //!Test if each decision is stored correctly, hence size=#decision
        Assert.AreEqual(reciever.getDecision(1).getDecisionID(),d1.getDecisionID());
        Assert.AreEqual(reciever.getDecision(1).getdecisionDescription(),d1.getdecisionDescription());
    }

    [Test]
    public void Reciever_to_StorageTest()
    {
        storage.AddDecision(reciever.getDecision(1));
        Assert.IsNotNull(storage.getDecision(1));
    }


    private void prepareData()
    {
        reciever.AddtoContainer(d1);
        reciever.AddtoContainer(d2);
        reciever.AddtoContainer(d3);
        reciever.AddtoContainer(d4);
        reciever.AddtoContainer(d5);
        reciever.AddtoContainer(d6);
        reciever.AddtoContainer(d7);
        reciever.AddtoContainer(d8);
    }
       

    }

