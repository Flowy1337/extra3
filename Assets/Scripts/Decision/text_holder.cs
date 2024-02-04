using System.Collections.Generic;

public abstract class text_holder
{
     
        public abstract void AddDecision(Decision d);
        public abstract Decision GetDecision(int decisionID);
        public abstract int Size();

        //!Generate a storage instanz via a singleton pattern,we use a singleton pattern since we only allow one object of the class storage to exist at a time



}
