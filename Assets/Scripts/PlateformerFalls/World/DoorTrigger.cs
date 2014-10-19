using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour
{

	void Start ()
    {
	
	}
	
	void Update ()
    {
	
	}

    void OnTriggerEnter (Collider hit)
    {
        if ("Player" ==  hit.tag)
        {
            hit.GetComponent<OwlLife>().hasWon = true;
        }
    }
}
