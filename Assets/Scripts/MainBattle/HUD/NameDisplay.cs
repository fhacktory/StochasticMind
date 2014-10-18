using UnityEngine;
using System.Collections;

public class NameDisplay : MonoBehaviour
{
    public Font     textFont;

    private EnemyAttributes     enemyAttributes;
    private PlayerAttributes    playerAttributes;

	void Start ()
    {
        enemyAttributes = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyAttributes>();
        playerAttributes = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerAttributes>();
	}
	
	void Update ()
    {
	
	}

    void OnGUI()
    {
        GUIStyle labelStyle = new GUIStyle(GUI.skin.label);

        labelStyle.font = textFont;
        labelStyle.fontSize = (int)(Screen.width * 0.04f);
        labelStyle.normal.textColor = new Color(0.4f, 0.1f, 0.6f);

        GUI.Label(new Rect(Screen.width * 0.25f, Screen.height * 0.02f,
            Screen.width * 0.25f, Screen.height * 0.25f), enemyAttributes.name, labelStyle);

        labelStyle.normal.textColor = new Color(0.1f, 0.4f, 0.3f);

        GUI.Label(new Rect(Screen.width * 0.57f, Screen.height * 0.6f,
            Screen.width * 0.25f, Screen.height * 0.25f), playerAttributes.name, labelStyle);
    }
}
