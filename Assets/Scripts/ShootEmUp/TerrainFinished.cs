using UnityEngine;
using System.Collections;

public class TerrainFinished : MonoBehaviour {

	private Transform trans;
    private Transform parentVar;

	// Use this for initialization
	void Start () {

        trans = transform;
        parentVar = trans.parent;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider hit)
    {
        if (hit.tag == "Player")
            parentVar.position -= parentVar.forward * 3950;
    }
}
