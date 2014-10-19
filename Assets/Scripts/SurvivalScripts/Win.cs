using UnityEngine;
using System.Collections;

public class Win : MonoBehaviour {

	void OnTriggerEnter(Collider hit)
    {
        if (hit.tag == "Player")
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
