using UnityEngine;
using System.Collections;

public class EnableWave : MonoBehaviour {

    [SerializeField]
    private GameObject wave;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider hit)
    {
        if (hit.tag == "Player")
        {
            wave.SetActiveRecursively(true);
        }
    }
}
