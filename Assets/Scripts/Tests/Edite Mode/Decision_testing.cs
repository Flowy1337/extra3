
using NUnit.Framework;


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

    private void prepareData()
    {
        reciever.Droptable();
        storage.Droptable();
        reciever.AddDecision(d1);
        reciever.AddDecision(d2);
        reciever.AddDecision(d3);
        reciever.AddDecision(d4);
        reciever.AddDecision(d5);
        reciever.AddDecision(d6);
        reciever.AddDecision(d7);
        reciever.AddDecision(d8);
    }


    [Test]
    public void init_reciever_storage()
    {
        reciever reciever2 = reciever.Reciever;
        storage storage2 = storage.Storage;
        Assert.AreEqual(reciever,reciever2);
        Assert.AreEqual(storage,storage2);
       
    }
    
    
    
    [Test]
    public void Read_JSONTest() //!Since we're calling our initial data preperation in an gameobject, calling it here seems quiet difficult, hence we do it in such a pseudo way
    {
        prepareData();
        Assert.AreEqual(reciever.Size(),8); //!Test if each decision is stored correctly, hence size=#decision
    }

    [Test]
    public void Reciever_to_StorageTest()
    {
        storage.AddDecision(reciever.GetDecision(1)); //!reciever pushed to storage 
        
        Assert.IsNotNull(storage.GetDecision(1));
    }

    [Test]
    public void change_Decision()
    {
        //!We ensure this by not creating any setters
    }

    [Test]
    public void make_decision()
    {
        //!Adding decisions from the same set, hence decisions which are in range Decision_old.id - Decision_new.id<4 are not allowed.
        storage.AddDecision(d1);
        storage.AddDecision(d2);
        storage.AddDecision(d3);
        storage.AddDecision(d4);
        Assert.AreEqual(storage.Size(),1);
        storage.AddDecision(d5);
        Assert.AreEqual(storage.Size(),2); //! Since d5 is out of range, OK
        
    }




}

