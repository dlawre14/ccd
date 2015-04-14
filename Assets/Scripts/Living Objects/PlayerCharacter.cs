using UnityEngine;
using System.Collections;

[RequireComponent (typeof(CharacterController))]
public class PlayerCharacter : BaseCharacter {

    CharacterController cc;

	// Use this for initialization
	void Start () {
        base.Start();

        cc = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        base.Update();

        if (Input.GetKey(KeyCode.W))
        {
            cc.Move(Vector3.forward * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            cc.Move(-Vector3.forward * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            cc.Move(Vector3.right * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            cc.Move(-Vector3.right * Time.deltaTime);
        }
    }
}
