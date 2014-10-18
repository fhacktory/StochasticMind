using UnityEngine;
using System.Collections;

public class SpawnMgr : MonoBehaviour {

    public GameObject[] Spawners;
    public GameObject   Enemy;
    public GameObject   Button;

    void Start()
    {
        Enemy.transform.position = Spawners[Random.Range(0, Spawners.Length)].transform.position;
        Button.transform.position = Spawners[Random.Range(0, Spawners.Length)].transform.position;
    }
}
