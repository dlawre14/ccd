using UnityEngine;
using System.Collections;

//This is the root of all objects with health

public abstract class CCD_Obj : MonoBehaviour {

    protected float health_curr;
    public float health_max;

    void Start() {
        health_curr = health_max;
    }

    public void TakeDamage(float damage)
    {
        health_curr -= damage;
    }

    public void RestoreDamage(float damage)
    {
        health_curr += damage;
    }
}
