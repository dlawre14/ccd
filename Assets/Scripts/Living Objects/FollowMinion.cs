using UnityEngine;
using System.Collections;

[RequireComponent (typeof(NavMeshAgent))]
public class FollowMinion : BaseCharacter {

    public GameObject target;
    private NavMeshAgent agent;

    void Start()
    {
        base.Start();

        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        base.Update();

        if (target != null)
        {
            if (Vector3.Distance(gameObject.transform.position, target.transform.position) <= 2)
                agent.SetPath(new NavMeshPath());
            else
                agent.SetDestination(target.transform.position);
        }
    } 
}
