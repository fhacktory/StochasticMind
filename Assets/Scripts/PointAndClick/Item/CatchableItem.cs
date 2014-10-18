using UnityEngine;
using System.Collections;

public class CatchableItem : MonoBehaviour {

    public bool isClicked;
    Transform   transf;

	void Start () {
        transf = transform;
	}
	
	void Update () {
	    if (isClicked)
        {
            Vector3 pos = Input.mousePosition;
            pos.z = 0;
            Ray ray = Camera.main.ScreenPointToRay(pos);
            Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);
            RaycastHit hit = new RaycastHit();
            Debug.Log(pos);

            if (Physics.Raycast(ray, out hit, 50, 1 << 8))
                transf.position = new Vector3(hit.point.x, 1, hit.point.z);
        }
	}

    void OnMouseDown()
    {
        isClicked = true;
    }

    void OnMouseUp()
    {
        isClicked = false;
    }
}
