using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    static PlayerAttributes player;
    public static bool      playerTurn;

	void Start ()
    {
        GameManager.playerTurn = true;
        GameManager.player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerAttributes>();
	}
	
	void Update ()
    {
	
	}

    public static void SendResult(GameResult result)
    {
        GameManager.playerTurn = !GameManager.playerTurn;
        GameManager.player += result;
    }
}
