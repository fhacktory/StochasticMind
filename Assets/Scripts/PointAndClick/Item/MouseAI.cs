using UnityEngine;
using System.Collections;

public class MouseAI : MonoBehaviour {

    Transform           transf;
    NavMeshAgent        navMeshAgent;

    Vector3             currentBushPos;
    GameObject          currentBush = null;


	void Start ()
    {
        transf = transform;
        currentBush = FindNearestBush();
        currentBushPos = currentBush.transform.position;
        navMeshAgent = gameObject.GetComponent<NavMeshAgent>();
	}
	
	void Update ()
    {
	    if (currentBush)
        {
            if (currentBushPos != currentBush.transform.position)
            {
                currentBush = FindNearestBush();
                currentBushPos = currentBush.transform.position;
            }
            else
                navMeshAgent.SetDestination(currentBush.transform.position + Vector3.left + Vector3.forward);
        }
	}

    GameObject FindNearestBush()
    {
        var bushes = GameObject.FindGameObjectsWithTag("Bush");

        var minDistance = float.MaxValue;
        GameObject nearestBush = null;
        foreach (var bush in bushes)
        {
            var distance = Vector3.Distance(transform.position, bush.transform.position);
            if (bush != currentBush && distance < minDistance)
            {
                nearestBush = bush;
                minDistance = distance;
            }
        }

        return nearestBush;
    }
}
