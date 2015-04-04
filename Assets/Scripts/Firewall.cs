using UnityEngine;
using System.Collections;

public class Firewall : CCD_Obj {

    private float health_curr;
    public float health_max;

	// Use this for initialization
	void Start () {
        health_curr = health_max;
	}
	
	// Update is called once per frame
	void Update () {
        if (health_curr <= 0)
        {
            Destroy(gameObject);
        }
	}

    public void TakeDamage(float damage)
    {
        health_curr -= damage;
    }
}
