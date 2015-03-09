using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 mp = Input.mousePosition;

        if (mp.x < Screen.width * 0.1f)
        {
            transform.Translate(-new Vector3(5, 0, 0) * Time.deltaTime, Space.World);
        }

        if (mp.x > Screen.width * 0.9f)
        {
            transform.Translate(new Vector3(5, 0, 0) * Time.deltaTime, Space.World);
        }

        if (mp.y < Screen.height * 0.1f)
        {
            transform.Translate(-new Vector3(0, 0, 5) * Time.deltaTime, Space.World);
        }

        if (mp.y > Screen.height * 0.9f)
        {
            transform.Translate(new Vector3(0, 0, 5) * Time.deltaTime, Space.World);
        }


	}
}
