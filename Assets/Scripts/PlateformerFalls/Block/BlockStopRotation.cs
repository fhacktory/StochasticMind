using UnityEngine;
using System.Collections;

public class BlockStopRotation : MonoBehaviour
{
    private Transform transf;

    void Start()
    {
        transf = transform;
    }
	
	void Update ()
    {
        transf.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
	}
}
