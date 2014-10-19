using UnityEngine;
using System.Collections;

public class MapEnd : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider hit)
    {
        Destroy(hit.gameObject);

    }
}
