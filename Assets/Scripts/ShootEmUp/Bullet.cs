using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {


    [SerializeField]
    private float speed;
    private Transform trans;


	// Use this for initialization
	void Start () {
        trans = transform;
	
	}
	
	// Update is called once per frame
	void Update () {
        trans.Translate(trans.up * speed * Time.deltaTime, Space.World);
    }

    void OnTriggerEnter(Collider hit)
    {
        Debug.Log(hit.name);
        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision hit)
    {
        Debug.Log(hit.collider.name);
        Destroy(gameObject);
    }
}
