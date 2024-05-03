using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler
{
    
    private int _eventID;
    private  EventEnum _type;
    private string _eventstring;
    
    public EventHandler(int eventID, EventEnum type, string eventstring)
    {
        this._eventID = eventID;
        this._type = type;
        this._eventstring = eventstring;
       
    }

    public EventEnum GetType
    {
        get {return _type; }
    }

    public int GetId
    {
        get { return _eventID; }
    }

    public string GetString
    {
        get
        {
            return _eventstring;
        }
    }
    public enum EventClass
    {
        inventory,
        notification,
    }

   
}

