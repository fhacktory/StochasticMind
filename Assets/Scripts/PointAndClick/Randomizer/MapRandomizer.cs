using UnityEngine;
using System.Collections;

public class MapRandomizer : MonoBehaviour {

    public int nbMouse;
    public int nbTree;
    public int nbBush;

    public int maxZoneLimit;
    public int minZoneLimit;

    public GameObject mousePrefab;
    public GameObject treePrefab;
    public GameObject bushPrefab;

	void Start ()
    {
        GameObject go;
        for (int i = 0; i < nbMouse; i++)
        {
            go = Instantiate(mousePrefab) as GameObject;
            go.transform.position = new Vector3(Random.Range(minZoneLimit, maxZoneLimit), 1, Random.Range(minZoneLimit, maxZoneLimit));
        }
        for (int i = 0; i < nbTree; i++)
        {
            go = Instantiate(treePrefab) as GameObject;
            go.transform.position = new Vector3(Random.Range(-250, 250), 4, Random.Range(-250, 250));
        }
        for (int i = 0; i < nbBush; i++)
        {
            go = Instantiate(bushPrefab) as GameObject;
            go.transform.position = new Vector3(Random.Range(minZoneLimit, maxZoneLimit), 1, Random.Range(minZoneLimit, maxZoneLimit));
        }
	}
	
	void Update () {
	
	}
}
