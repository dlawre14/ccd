using UnityEngine;
using System.Collections;

[RequireComponent (typeof(NavMeshAgent))]
public class Avatar : CCD_Obj {

    private NavMeshAgent agent;

    private GameObject target;

	// Use this for initialization
	void Start () {
        base.Start();
        agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        base.Update();
	}

    void FixedUpdate()
    {
        if (target != null)
        {
            if (agent.pathEndPosition != target.transform.position)
            {
                Debug.Log("setting desitnation");
                agent.ResetPath();
                agent.SetDestination(target.transform.position);
                agent.Resume();
            }

            if ((transform.position - target.transform.position).magnitude <= 3)
            {
                agent.Stop();
            }
        }
    }

    //Sends command to move to location
    public void MoveLocation(Vector3 pos)
    {
        target = null;
        
        NavMeshPath p = new NavMeshPath();
        agent.CalculatePath(pos, p);
        agent.SetPath(p);
    }

    public void SetTarget(GameObject t)
    {
        target = t;
    }
}
