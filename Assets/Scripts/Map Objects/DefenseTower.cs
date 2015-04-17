using UnityEngine;
using System.Collections;

/** This requires a sphere collider for area detection.
 * 
 *  The towers exist in their own physics layer which only interacts with creeps and players.
 */

[RequireComponent (typeof(SphereCollider))]
public class DefenseTower : MonoBehaviour {

    private GameObject target;

    void OnTriggerEnter(Collider c)
    {
        Debug.Log("Entering a collision!");
        if (target == null)
        {
            if (c.gameObject.GetComponent<BaseCharacter>() != null)
                target = c.gameObject;
        }
    }

    void OnTriggerExit(Collider c)
    {
        Debug.Log("Exiting a collision!");
        if (c.gameObject == target)
        {
            target = null;
        }
    }

    void Start()
    {
        StartCoroutine(AttackTarget());
    }

    void Update()
    {
        if (target != null)
        {
            Debug.DrawLine(transform.position, target.transform.position, Color.yellow);
        }
    }

    IEnumerator AttackTarget()
    {
        while (true)
        {
            if (target != null)
            {
                BaseCharacter bc = target.GetComponent<BaseCharacter>();

                if (bc != null)
                    bc.ChangeHealth(-10.0f);

                yield return new WaitForSeconds(1.5f);
            }
            else
            {
                yield return null;
            }
        }
    }
}
