using UnityEngine;
using System.Collections;

public class ActionsMenu : MonoBehaviour
{
    public Font     textFont;

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
                var enemy = GameObject.FindGameObjectWithTag("Enemy");
                var player = GameObject.FindGameObjectWithTag("Player");
                enemy.GetComponent<EnemyAttributes>().inBattle = false;
                player.GetComponent<PlayerAttributes>().inBattle = false;
                enemyTurnTimer = 0.0f;
                var randomNum = Random.Range(5, 7);
                Application.LoadLevel(randomNum);
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

        if (GameManager.playerTurn)
        {
            if (GUI.Button(new Rect(Screen.width * 0.15f, Screen.height * 0.85f,
                                Screen.width * 0.2f, Screen.height * 0.1f), "Attack", buttonStyle))
            {
                var player = GameObject.FindGameObjectWithTag("Player");
                enemyAttributes.inBattle = false;
                player.GetComponent<PlayerAttributes>().inBattle = false;
                Application.LoadLevel(Random.Range(3, 5));
            }

            buttonStyle.normal.textColor = new Color(0.8f, 0.8f, 0.0f);

            if (GUI.Button(new Rect(Screen.width * 0.5f, Screen.height * 0.85f,
                                Screen.width * 0.2f, Screen.height * 0.1f), "Hunt", buttonStyle))
            {
                var player = GameObject.FindGameObjectWithTag("Player");
                enemyAttributes.inBattle = false;
                player.GetComponent<PlayerAttributes>().inBattle = false;
                Application.LoadLevel(2);
            }
        }
        else
        {
            var labelStyle = new GUIStyle();

            labelStyle.fontSize = (int)(Screen.width * 0.06f);
            labelStyle.font = textFont;
            labelStyle.normal.textColor = new Color(0.8f, 0.8f, 0.7f);

            GUI.Label(new Rect(Screen.width * 0.18f, Screen.height * 0.85f,
                Screen.width * 0.4f, Screen.height * 0.2f), "Wild Noel Attacks !", labelStyle);
        }
	}
}
