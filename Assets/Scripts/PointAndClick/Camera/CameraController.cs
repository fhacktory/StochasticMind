using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public float speed;
    public KeyCode forward;
    public KeyCode backward;
    public KeyCode left;
    public KeyCode right;

    Transform transf;

	void Start () {
        transf = transform;
  	}
	
	void Update () {
	    if (Input.GetKey(forward))
            transf.Translate((Vector3.left + Vector3.forward) * speed * Time.deltaTime, Space.World);
        if (Input.GetKey(backward))
            transf.Translate((Vector3.right + Vector3.back) * speed * Time.deltaTime, Space.World);
        if (Input.GetKey(left))
            transf.Translate((Vector3.left + Vector3.back) * speed * Time.deltaTime, Space.World);
        if (Input.GetKey(right))
            transf.Translate((Vector3.right + Vector3.forward) * speed * Time.deltaTime, Space.World);

        if (transf.position.x > 50)
            transf.position = new Vector3(50, transf.position.y, transf.position.z);
        if (transf.position.x < -50)
            transf.position = new Vector3(-50, transf.position.y, transf.position.z);
        if (transf.position.z > 50)
            transf.position = new Vector3(transf.position.x, transf.position.y, 50);
        if (transf.position.z < -50)
            transf.position = new Vector3(transf.position.x, transf.position.y, -50);
	}
}
