using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    static PlayerAttributes player;

	void Start ()
    {
        GameManager.player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerAttributes>();
	}
	
	void Update ()
    {
	
	}

    public static void SendResult(GameResult result)
    {
        Debug.Log("Receive result");
        GameManager.player += result;
    }
}
