using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Handy : Items
{
    private static Handy _instance;
    private static int _count;
    private static string _textHistory;
    private bool _active;
    private Handy()
    {
        
    }
    public static Handy Instanz
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Handy();
            }

            return _instance;
        }
    }


    public override bool Active()
    {
        return _active;
    }

    public override void open_item()
    {
        _count++;
        _active = true;

    }

    public override void close_item()
    {
        _active = false;
    }

    
    public void insert_text(string str)
    {
        if (_active)
        { 
            _textHistory += str;
        }
    }
}
