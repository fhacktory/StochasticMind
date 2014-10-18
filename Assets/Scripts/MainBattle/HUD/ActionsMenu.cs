using UnityEngine;
using System.Collections;

public class ActionsMenu : MonoBehaviour
{
    public Font textFont;

    private EnemyAttributes     enemyAttributes;

	void Start ()
	{
        enemyAttributes = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyAttributes>();
	}
	
	void Update ()
	{
	
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
            enemyAttributes.life -= 1;

        buttonStyle.normal.textColor = new Color(0.1f, 0.4f, 0.5f);

        GUI.Button(new Rect(Screen.width * 0.4f, Screen.height * 0.85f,
                            Screen.width * 0.2f, Screen.height * 0.1f), "Defense", buttonStyle);

        buttonStyle.normal.textColor = new Color(0.8f, 0.8f, 0.0f);

        GUI.Button(new Rect(Screen.width * 0.7f, Screen.height * 0.85f,
                            Screen.width * 0.2f, Screen.height * 0.1f), "Item", buttonStyle);
	}
}
