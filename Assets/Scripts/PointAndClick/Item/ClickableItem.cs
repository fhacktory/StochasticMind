using UnityEngine;
using System.Collections;

public class ClickableItem : MonoBehaviour {

	void Start ()
    {
	    
	}
	
	void Update ()
    {
	
	}

    void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
