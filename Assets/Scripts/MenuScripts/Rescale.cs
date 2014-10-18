using UnityEngine;
using System.Collections;

public class Rescale : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.localScale = new Vector3(Screen.width, Screen.height, 0);
	}
	
	// Update is called once per frame
}
