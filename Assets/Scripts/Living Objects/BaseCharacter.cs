using UnityEngine;
using System.Collections;

/** This is a base class to encapsulate objects with health. */

public class BaseCharacter : MonoBehaviour {

    private float _health;
    public float maxHealth;

	// Use this for initialization
	protected void Start () {
        _health = maxHealth;
	}

    protected void Update()
    {
        if (_health <= 0)
        {
            Destroy(gameObject);
        }
    }

    // delta can be positive or negative, we'll allow the accessor to decide
    public void ChangeHealth(float delta)
    {
        _health += delta;
    }
}
