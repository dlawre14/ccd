using UnityEngine;
using System.Collections;

[RequireComponent (typeof(CharacterController))]
public class PlayerCharacter : BaseCharacter {

    public GameObject projectile;
    public float speed;

    private CharacterController cc;

	// Use this for initialization
	void Start () {
        base.Start();

        cc = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        base.Update();

        Vector3 mp = Input.mousePosition;
        Ray r = Camera.main.ScreenPointToRay(mp);
        RaycastHit hit;

        if (Physics.Raycast(r, out hit, 1000, 1<<10))
        {
            transform.LookAt(hit.point);
            transform.rotation = Quaternion.Euler(transform.eulerAngles - new Vector3(transform.eulerAngles.x, 0, 0));
        }

        if (Input.GetKey(KeyCode.W))
        {
            cc.Move(Vector3.forward * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            cc.Move(-Vector3.forward * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            cc.Move(Vector3.right * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            cc.Move(-Vector3.right * Time.deltaTime * speed);
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(projectile, transform.position, transform.rotation);
        }
    }
}
