using UnityEngine;
using System.Collections;

public class Firewall : CCD_Obj {

    private float health_curr;
    private float health_max;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public override void OnReceiveClick()
    {
        throw new System.NotImplementedException();   
    }

    public override void OnReceiveInteract()
    {
        throw new System.NotImplementedException();
    }
}
