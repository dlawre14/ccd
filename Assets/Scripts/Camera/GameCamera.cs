using UnityEngine;
using System.Collections;

public class GameCamera : MonoBehaviour {

    //This is the player
    public float xoffset;
    public float yoffset;
    public float zoffset;
    private GameObject followTarget;

    public void SetFollow(GameObject target)
    {
        followTarget = target;
    }

    void LateUpdate()
    {
        if (followTarget != null)
        {
            gameObject.transform.position = followTarget.transform.position + new Vector3(xoffset, yoffset, zoffset);
        }
    }
}
