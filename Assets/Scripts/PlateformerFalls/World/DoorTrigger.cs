using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour
{

	void Start ()
    {
	
	}
	
	void Update ()
    {
	
	}

    void OnTriggerEnter (Collider hit)
    {
        if ("Player" ==  hit.tag)
        {
            GameManager.SendResult(new GameResult(0, 0, 0));
            var enemy = GameObject.FindGameObjectWithTag("Enemy");
            var player = GameObject.FindGameObjectWithTag("Player");
            enemy.GetComponent<EnemyAttributes>().inBattle = true;
            player.GetComponent<PlayerAttributes>().inBattle = true;
            Application.LoadLevel(1);
        }
    }
}
