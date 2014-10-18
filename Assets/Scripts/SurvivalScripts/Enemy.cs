using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

    public GameObject       Target;

    private NavMeshAgent    agent;
    private SpawnMgr        spawnerManager;

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
        spawnerManager = GameObject.FindGameObjectWithTag("Maze").GetComponent<SpawnMgr>();
        transform.position = spawnerManager.Spawners[Random.Range(0, spawnerManager.Spawners.Length)].transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        agent.SetDestination(Target.transform.position);
	}
}
