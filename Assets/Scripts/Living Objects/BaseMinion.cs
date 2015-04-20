using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseMinion : BaseCharacter {

    /** 
     * This is a root class containining all minion functions
     * 
     * This is used for allowing customized minions 
     * 
     */

    private Dictionary<string, string> attributes;

    protected void Start()
    {
        base.Start();
        attributes = new Dictionary<string, string>();
    }

    public void AssignAttributes(Dictionary<string, string> attr)
    {
        attributes = attr;
    }

    private void BuildMinion()
    {
        foreach (KeyValuePair<string, string> pair in attributes)
        {
            //TODO implement builder
        }
    }

    public void AssignColor(Color c)
    {
        GetComponent<Renderer>().material.color = c;
    }
}
