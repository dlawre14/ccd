using UnityEngine;
using System.Collections;

[RequireComponent (typeof(NavMeshAgent))]
public class Avatar : CCD_Obj {

    private NavMeshAgent agent;

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //Sends command to move to location
    public void MoveLocation(Vector3 pos)
    {
        NavMeshPath p = new NavMeshPath();
        agent.CalculatePath(pos, p);
        agent.SetPath(p);
    }
}
