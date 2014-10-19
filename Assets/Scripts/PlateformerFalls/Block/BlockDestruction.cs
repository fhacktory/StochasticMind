using UnityEngine;
using System.Collections;

public class BlockDestruction : MonoBehaviour
{
    private Transform   transf;

	void Start ()
    {
        transf = transform;
	}
	
	void OnCollisionEnter (Collision hit)
    {
        if ("Player" == hit.collider.tag)
        {
            hit.collider.GetComponent<OwlLife>().life -= 1;
            Destroy(gameObject);
        }

        if ("Walls" == hit.collider.tag ||
            "Block" == hit.collider.tag)
        {
            Destroy(gameObject);
        }
	}
}
