using UnityEngine;
using System.Collections;

public class PlayerProjectile : MonoBehaviour {

    public float velocity;

	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * Time.deltaTime * velocity);
	}
}
