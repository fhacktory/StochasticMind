using UnityEngine;
using System.Collections;

namespace Survival
{

    public class Enemy : MonoBehaviour
    {

        public GameObject Target;

        private NavMeshAgent agent;

        // Use this for initialization
        void Start()
        {
            agent = GetComponent<NavMeshAgent>();
        }

        // Update is called once per frame
        void Update()
        {
            agent.SetDestination(Target.transform.position);
        }

        void OnCollisionEnter(Collision hit)
        {
            if (hit.transform.tag == "Player")
                Debug.Log("YOU LOSE");
        }
    }
}