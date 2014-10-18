using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WavefHACKtory : MonoBehaviour
{

    [SerializeField]
    private GameObject[] prefabs;
    [SerializeField]
    private GameObject[] waves;
    [SerializeField]
    private float YPos;

    private List<Vector2> previousPos;


    // Use this for initialization
    void Start()
    {


        previousPos = new List<Vector2>();


        /* int i = Random.Range(2, 4);
         i *= difficulty;

         for (; i > 0; --i)
         {
             Instantiate(prefabs[Random.Range(0, prefabs.Length)], RandomEnemyPosition(), Quaternion.identity);
         }*/
    }

    Vector3 RandomEnemyPosition()
    {
        float x;
        float y = YPos;
        float z;

        if (previousPos.Count == 0)


            foreach (Vector2 previous in previousPos)
            {
                //if (Random.
            }

        return Vector3.zero;

    }
}
