using UnityEngine;
using System.Collections;

public class Win : MonoBehaviour {

	void OnTriggerEnter(Collider hit)
    {
        if (hit.tag == "Player")
            Debug.Log("You Win");
    }
}
