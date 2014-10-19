using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WavefHACKtory : MonoBehaviour
{

    [SerializeField]
    private GameObject[] prefabs;
    [SerializeField]
    private float YPos;
    [SerializeField]
    private float minZRange = 1.0f;
    [SerializeField]
    private float maxZRange = 3.0f;
    [SerializeField]
    private float minX = 1.0f;
    [SerializeField]
    private float maxX = 3.0f;
    [SerializeField]
    private int minEnemies = 2;
    [SerializeField]
    private int maxEnemies = 4;

    [SerializeField]
    private int difficulty = 1;

    private float incrasedZ = 0.0f;
    private List<GameObject> enemies;
    private float previousX;
    private Transform trans;


    // Use this for initialization
    void Start()
    {
        trans = transform;
        enemies = new List<GameObject>();
        EnemySpawn();
    }

    void Update()
    {
        if (enemies.FindAll(x => x == null).Count == enemies.Count)
        {
            enemies.Clear();
            EnemySpawn();
        }
    }

    void EnemySpawn()
    {
        int numberOfEnemies = Random.Range(minEnemies, maxEnemies);
        numberOfEnemies *= difficulty;

        for (int i = 0; i < numberOfEnemies; i++)
        {
            float z = Random.Range(minZRange, maxZRange);
            float x;

            if (Random.Range(0, 2) == 1)
                x = Random.Range(minX, previousX - 40);
            else
                x = Random.Range(previousX + 40, maxX);

            Vector3 position = new Vector3(x, YPos, z + trans.position.z + incrasedZ);
            enemies.Add(Instantiate(prefabs[Random.Range(0, prefabs.Length)], position, Quaternion.identity) as GameObject);
            previousX = x;
            incrasedZ += z;
        }
        previousX = 0;
        incrasedZ = 0;
        difficulty += 1;
    }


}
