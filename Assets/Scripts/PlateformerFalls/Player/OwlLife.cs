using UnityEngine;
using System.Collections;

public class OwlLife : MonoBehaviour
{
    public int  life;
    public bool hasWon;

	void Start ()
    {
        life = 1;
	}
	
	void Update ()
    {
        if (0 == life)
        {
            GameManager.SendResult(new GameResult(-1, 0, 0));
            var enemy = GameObject.FindGameObjectWithTag("Enemy");
            var player = GameObject.FindGameObjectWithTag("Player");
            enemy.GetComponent<EnemyAttributes>().inBattle = true;
            player.GetComponent<PlayerAttributes>().inBattle = true;
            Application.LoadLevel(1);
        }
	}
}
