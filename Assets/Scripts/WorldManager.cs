using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//This class handles the entirety of the game world
//All objects send queries to this object for information

public class WorldManager : MonoBehaviour {

    public GameObject overlayCanvas;

    private Avatar avatar;

    private Vector3 _activeClickPos;

    //This method handles clicking in the world
    //If this returns null we did not click anything

    private GameObject ClickWorld()
    {
        Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(r, out hit, 1000))
        {
            _activeClickPos = hit.point;
            return hit.transform.gameObject;
        }

        return null;
    }

    void Start()
    {
        CheckAvatarStatus();
        StartCoroutine(CheckAvatarTick());
    }

	void Update () {
        if (Input.GetMouseButtonDown(1) && avatar != null)
        {
            GameObject activeObj = ClickWorld();
            if (activeObj != null)
            {
                Firewall f;
                Ground g;
                //If a firewall...
                if ((f = activeObj.GetComponent<Firewall>()) != null)
                {
                    Debug.Log("Hit firewall");
                    avatar.SetTarget(activeObj);
                }

                //If ground...
                if ((g = activeObj.GetComponent<Ground>()) != null)
                {
                    Debug.Log("Hit ground");
                    avatar.MoveLocation(_activeClickPos);
                }

                //If an enemy unit...
            }
        }
	}

    public void CheckAvatarStatus()
    {
            avatar = FindObjectOfType<Avatar>();
    }

    //Note: this is a backup in case other scripts fail to update the agent's status
    private IEnumerator CheckAvatarTick()
    {
        while (true) {
            yield return new WaitForSeconds(3);
            CheckAvatarStatus();
        }
    }
}
