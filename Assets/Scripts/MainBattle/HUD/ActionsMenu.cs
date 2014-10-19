﻿using UnityEngine;
using System.Collections;

public class ActionsMenu : MonoBehaviour
{
    public Font textFont;

    private EnemyAttributes     enemyAttributes;
    private float               enemyTurnTimer;

	void Start ()
	{
        enemyAttributes = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyAttributes>();
	}
	
	void Update ()
	{
	    if (!GameManager.playerTurn)
        {
            enemyTurnTimer += Time.deltaTime;
            if (enemyTurnTimer >= 2.0f)
            {
                Debug.Log("Enemy turn");
                var enemy = GameObject.FindGameObjectWithTag("Enemy");
                var player = GameObject.FindGameObjectWithTag("Player");
                enemy.GetComponent<EnemyAttributes>().inBattle = false;
                player.GetComponent<PlayerAttributes>().inBattle = false;
                enemyTurnTimer = 0.0f;
                GameManager.playerTurn = true;
                Application.LoadLevel(5);
            }
        }
	}

	void OnGUI()
	{
		GUIStyle buttonStyle = new GUIStyle(GUI.skin.button);
		
		buttonStyle.fontSize = (int)(Screen.width * 0.027f);
		buttonStyle.font = textFont;
		buttonStyle.hover.textColor = new Color(0.4f, 0.0f, 0.1f);
        buttonStyle.normal.textColor = new Color(0.8f, 0.4f, 0.1f);

        if (GUI.Button(new Rect(Screen.width * 0.1f, Screen.height * 0.85f,
                            Screen.width * 0.2f, Screen.height * 0.1f), "Attack", buttonStyle))
        {
            var enemy = GameObject.FindGameObjectWithTag("Enemy");
            var player = GameObject.FindGameObjectWithTag("Player");
            enemy.GetComponent<EnemyAttributes>().inBattle = false;
            player.GetComponent<PlayerAttributes>().inBattle = false;
            GameManager.playerTurn = false;
            Application.LoadLevel(4);
        }

        buttonStyle.normal.textColor = new Color(0.1f, 0.4f, 0.5f);

        GUI.Button(new Rect(Screen.width * 0.4f, Screen.height * 0.85f,
                            Screen.width * 0.2f, Screen.height * 0.1f), "Defense", buttonStyle);

        buttonStyle.normal.textColor = new Color(0.8f, 0.8f, 0.0f);

        if (GUI.Button(new Rect(Screen.width * 0.7f, Screen.height * 0.85f,
                            Screen.width * 0.2f, Screen.height * 0.1f), "Hunt", buttonStyle))
        {
            var enemy = GameObject.FindGameObjectWithTag("Enemy");
            var player = GameObject.FindGameObjectWithTag("Player");
            enemy.GetComponent<EnemyAttributes>().inBattle = false;
            player.GetComponent<PlayerAttributes>().inBattle = false;
            GameManager.playerTurn = false;
            Application.LoadLevel(2);
        }
	}
}
