using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

    public float    time;

	void Start ()
    {
	
	}

	void Update ()
    {
        time -= Time.deltaTime;

        var mice = GameObject.FindGameObjectsWithTag("Mouse");


        if (mice.Length < 1)
        {
            GameManager.SendResult(new GameResult(1, 0, 0));
            var enemy = GameObject.FindGameObjectWithTag("Enemy");
            var player = GameObject.FindGameObjectWithTag("Player");
            enemy.GetComponent<EnemyAttributes>().inBattle = true;
            player.GetComponent<PlayerAttributes>().inBattle = true;
            Application.LoadLevel(1);
        }
        else if (time <= 0.0f)
        {
            GameManager.SendResult(new GameResult(0, 0, 0));
            var enemy = GameObject.FindGameObjectWithTag("Enemy");
            var player = GameObject.FindGameObjectWithTag("Player");
            enemy.GetComponent<EnemyAttributes>().inBattle = true;
            player.GetComponent<PlayerAttributes>().inBattle = true;
            Application.LoadLevel(1);
        }
	}

    void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 200, 50), "Time: " + time);

    }
}
