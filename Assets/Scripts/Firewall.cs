using UnityEngine;
using System.Collections;

public class Firewall : CCD_Obj {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (health_curr <= 0)
        {
            Destroy(gameObject);
        }
	}
}
 