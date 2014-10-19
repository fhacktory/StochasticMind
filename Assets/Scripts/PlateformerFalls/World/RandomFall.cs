using UnityEngine;
using System.Collections;

public class RandomFall : MonoBehaviour
{
    public GameObject   block;

    private Transform   transf;
    private float       timeToSpawn;
    private GameObject  arena;

	void Start ()
    {
	    transf = transform;
        timeToSpawn = 0;
        arena = GameObject.FindGameObjectWithTag("Arena");
	}
	
	void Update ()
    {
        if (0 >= timeToSpawn)
        {
            var randomNum = Random.Range(transf.position.x - (transf.localScale.x * arena.GetComponent<Transform>().localScale.x) / 2,
                transf.position.x + (transf.localScale.x * arena.GetComponent<Transform>().localScale.x) / 2);
            var newBlock = Instantiate(block, new Vector3(randomNum, 3, transf.position.z), Quaternion.identity) as GameObject;
            newBlock.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            timeToSpawn = 2;
        }
        timeToSpawn -= Time.deltaTime;
	}
}
