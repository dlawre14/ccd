using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//This is the root of all objects with health

public abstract class CCD_Obj : MonoBehaviour {

    protected float health_curr;
    public float health_max;

    public Font labelFont;

    private GameObject canvas;
    private GameObject label;

    protected void Start() {
        health_curr = health_max;
    }

    protected void Update()
    {
        if (health_curr <= 0)
        {
            Destroy(gameObject);
        }
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
