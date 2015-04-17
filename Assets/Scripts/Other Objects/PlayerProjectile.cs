using UnityEngine;
using System.Collections;

public class PlayerProjectile : MonoBehaviour {

    public float velocity;

	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * Time.deltaTime * velocity);
	}

    void OnCollisionEnter(Collision c)
    {
        DefenseTower d = c.gameObject.GetComponent<DefenseTower>();

        if (d != null)
        {
            d.GetComponentInChildren<BaseCharacter>().ChangeHealth(-10);
        }

        Destroy(gameObject);
    }
}
